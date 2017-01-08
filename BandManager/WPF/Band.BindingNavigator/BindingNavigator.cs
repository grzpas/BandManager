using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BandBindingNavigator
{
    public class BindingNavigator : Control, INotifyPropertyChanged
    {
        private int _currentItemIndex;
        private int _itemsCount;

        static BindingNavigator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BindingNavigator),
                new FrameworkPropertyMetadata(typeof(BindingNavigator)));
        }

        public BindingNavigator()
        {
            Commands = new InternalCommands
            {
                PreviousItemCommand = new RelayCommand(GoToPreviousItem, CanGoToPreviousItem),
                NextItemCommand = new RelayCommand(GoToNextItem, CanGoToNextItem),
                FirstItemCommand = new RelayCommand(GoToFirstItem, CanGoToFirstItem),
                LastItemCommand = new RelayCommand(GoToLastItem, CanGoToLastItem),
                AddNewItemCommand = new RelayCommand(AddNewItem, CanAddNewItem),
                DeleteItemCommand = new RelayCommand(DeleteItem, CanDeleteItem)
            };
        }

        public int ItemsCount
        {
            get { return _itemsCount; }
            private set
            {
                _itemsCount = value;
                OnPropertyChanged("ItemsCount");
                RefreshNavigationCommands();
            }
        }

        public object CurrentItem
        {
            get
            {
                if (ItemsSource == null)
                {
                    return null; //GP
                }
                var i = 1;
                foreach (var item in ItemsSource)
                {
                    if (i == CurrentItemIndex)
                        return item;
                    i++;
                }

                return null;
            }
        }

        public int CurrentItemIndex
        {
            get { return _currentItemIndex; }
            set
            {
                if (value > ItemsCount)
                    return;
                if (value < 1)
                    return;

                UnsafelyAlterItemIndex(value);
            }
        }

        public bool IsItemInContext => CurrentItem != null;

        private void OnItemsSourceChanged()
        {
            UpdateItemsCount();

            CurrentItemIndex = ItemsCount > 0 ? 1 : 0;
        }

        private void UpdateItemsCount()
        {
            var i = 0;
            foreach (var item in ItemsSource)
                i++;

            ItemsCount = i;
        }

        private void UnsafelyAlterItemIndex(int index)
        {
            _currentItemIndex = index;
            OnPropertyChanged("CurrentItemIndex");
            OnPropertyChanged("CurrentItem");
            OnPropertyChanged("IsItemInContext");
            RefreshNavigationCommands();
        }

        private static Type GetEnumerableGenericArgument(Type type)
        {
            if (type == typeof(string))
                return null;

            var enumerableGenericArgument = type
                .GetInterfaces()
                .FirstOrDefault(i => i.Name.Contains("IEnumerable") && i.IsGenericType);

            if (enumerableGenericArgument != null)
                return enumerableGenericArgument.GetGenericArguments().FirstOrDefault();

            return null;
        }

        private static bool IsCollection(IEnumerable obj)
        {
            if (obj == null)
            {
                return false; //GP
            }
            return GetEnumerableGenericArgument(obj.GetType()) != null
                   && obj is IList;
        }

        #region Dependency properties

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable) GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(BindingNavigator),
                new PropertyMetadata(null, OnItemsSourceChanged));

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var navigator = d as BindingNavigator;
            navigator?.OnItemsSourceChanged();
        }

        public ICommand AddNewItemCommand
        {
            get { return (ICommand) GetValue(AddNewItemCommandProperty); }
            set { SetValue(AddNewItemCommandProperty, value); }
        }

        public static readonly DependencyProperty AddNewItemCommandProperty =
            DependencyProperty.Register("AddNewItemCommand", typeof(ICommand), typeof(BindingNavigator),
                new PropertyMetadata(null, OnAddNewItemCommandChanged));

        private static void OnAddNewItemCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (e.NewValue as ICommand).CanExecuteChanged += (d as BindingNavigator).Commands.OnAddNewItemCanExecuteChanged;
            if (e.OldValue != null)
                (e.OldValue as ICommand).CanExecuteChanged -=
                    (d as BindingNavigator).Commands.OnAddNewItemCanExecuteChanged;
        }

        public ICommand DeleteItemCommand
        {
            get { return (ICommand) GetValue(DeleteItemCommandProperty); }
            set { SetValue(DeleteItemCommandProperty, value); }
        }

        public static readonly DependencyProperty DeleteItemCommandProperty =
            DependencyProperty.Register("DeleteItemCommand", typeof(ICommand), typeof(BindingNavigator),
                new PropertyMetadata(null, OnDeleteItemCommandChanged));

        private static void OnDeleteItemCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (e.NewValue as ICommand).CanExecuteChanged += (d as BindingNavigator).Commands.OnDeleteItemCanExecuteChanged;
            if (e.OldValue != null)
                (e.OldValue as ICommand).CanExecuteChanged -=
                    (d as BindingNavigator).Commands.OnDeleteItemCanExecuteChanged;
        }

        public ICommand SaveCommand
        {
            get { return (ICommand) GetValue(SaveCommandProperty); }
            set { SetValue(SaveCommandProperty, value); }
        }

        public static readonly DependencyProperty SaveCommandProperty =
            DependencyProperty.Register("SaveCommand", typeof(ICommand), typeof(BindingNavigator),
                new UIPropertyMetadata(null));

        #endregion

        #region Item Navigation members

        public InternalCommands Commands { get; }

        private bool CanGoToNextItem(object parameter)
        {
            return CurrentItemIndex < ItemsCount;
        }

        private void GoToNextItem(object parameter)
        {
            CurrentItemIndex++;
        }

        private bool CanGoToPreviousItem(object parameter)
        {
            return CurrentItemIndex > 1;
        }

        private void GoToPreviousItem(object parameter)
        {
            CurrentItemIndex--;
        }

        private bool CanGoToFirstItem(object parameter)
        {
            return ItemsCount > 0 && CurrentItemIndex > 1;
        }

        private void GoToFirstItem(object parameter)
        {
            CurrentItemIndex = 1;
        }

        private bool CanGoToLastItem(object parameter)
        {
            return ItemsCount > 0 && CurrentItemIndex < ItemsCount;
        }

        private void GoToLastItem(object parameter)
        {
            CurrentItemIndex = ItemsCount;
        }

        private bool CanAddNewItem(object parameter)
        {
            if (AddNewItemCommand != null)
                return AddNewItemCommand.CanExecute(parameter);
            return IsCollection(ItemsSource);
        }

        private void AddNewItem(object parameter)
        {
            if (AddNewItemCommand != null)
            {
                AddNewItemCommand.Execute(parameter);
            }
            else
            {
                var list = ItemsSource as IList;
                var newItem = Activator.CreateInstance(GetEnumerableGenericArgument(ItemsSource.GetType()));
                list.Add(newItem);
            }
            UpdateItemsCount();
            GoToLastItem(null);
        }

        private bool CanDeleteItem(object parameter)
        {
            if (DeleteItemCommand != null)
                return CurrentItemIndex > 0
                       && DeleteItemCommand.CanExecute(parameter);
            return CurrentItemIndex > 0
                   && IsCollection(ItemsSource);
        }

        private void DeleteItem(object parameter)
        {
            if (DeleteItemCommand != null)
                DeleteItemCommand.Execute(parameter);
            else
                (ItemsSource as IList).Remove(CurrentItem);
            if (CurrentItemIndex != 1 && ItemsCount > 1 || CurrentItemIndex == 1 && ItemsCount == 1)
                _currentItemIndex--;
            UpdateItemsCount();
            UnsafelyAlterItemIndex(_currentItemIndex);
        }

        private void RefreshNavigationCommands()
        {
            Commands.PreviousItemCommand.RaiseCanExecuteChanged();
            Commands.NextItemCommand.RaiseCanExecuteChanged();
            Commands.FirstItemCommand.RaiseCanExecuteChanged();
            Commands.LastItemCommand.RaiseCanExecuteChanged();
            Commands.AddNewItemCommand.RaiseCanExecuteChanged();
            Commands.DeleteItemCommand.RaiseCanExecuteChanged();
        }

        #endregion

        #region INotifyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}