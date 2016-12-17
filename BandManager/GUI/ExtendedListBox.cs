namespace GUI
{
    public partial class ExtendedListBox 
    {
        public ExtendedListBox()
        {
            InitializeComponent();            
            DragDrop += OnDragDrop;
            DragEnter += OnDragEnter;
            MouseDown += OnMouseDown;
        }
    }
}
