using System;
using System.Net;
using Google.GData.Calendar;
using Google.GData.Client;
using Google.GData.Extensions;

namespace Band.Model.Google
{
    public class PBCalendar
    {
        private const string URI = @"https://calendar.google.com/calendar/ical/grzegorz.pasternak.m%40googlemail.com/public/basic.ics";

        private void SetDefaultProxy(CalendarService _service)
        {
            GDataRequestFactory requestFactory = (GDataRequestFactory)_service.RequestFactory;
            IWebProxy iProxy = WebRequest.DefaultWebProxy;
            if (iProxy != null)
            {
                //var proxy = iProxy.GetProxy(new Uri(URI));
                //var myProxy = new WebProxy(proxy) { Credentials = CredentialCache.DefaultCredentials, UseDefaultCredentials = true };
                // potentially, setup credentials on the proxy here
                //requestFactory.Proxy = myProxy;
            }
        }

        private EventEntry GetEventFeed(EventQuery query)
        {
            CalendarService service = GetService();
            EventFeed resultFeed = null;
            try
            {
                resultFeed = service.Query(query);
            }
            catch (NotSupportedException)
            {
                GDataRequestFactory requestFactory = (GDataRequestFactory)service.RequestFactory;
                requestFactory.Proxy = null;
                resultFeed = service.Query(query);
            }

            if (resultFeed != null && resultFeed.Entries != null && resultFeed.Entries.Count > 0)
            {
                return (EventEntry)resultFeed.Entries[0];
            }
            return null;
        }

        private CalendarService GetService()
        {
            CalendarService _service = new CalendarService("Maestro");
            _service.setUserCredentials("grzegorz.pasternak.m@gmail.com", "Mama1KochamCie");
            SetDefaultProxy(_service);
            return _service;
        }

        public EventEntry GetUpcomingEvent()
        {
            var query = new EventQuery(URI)
                            {
                                FutureEvents = true,
                                SingleEvents = true,
                                SortOrder = CalendarSortOrder.ascending,
                                ExtraParameters = "orderby=starttime",
                                NumberToRetrieve = 1
               
                            };
            return GetEventFeed(query);
        }

        

        public EventEntry GetUpcomingEvent(DateTime startDateTime, DateTime endDateTime)
        {
            var query = new EventQuery(URI) {StartTime = startDateTime, EndTime = endDateTime};
            return GetEventFeed(query);
        }
        
        public void CreateEvent(string title, string content, string where, DateTime when)
        {
            EventEntry entry = new EventEntry {Title = {Text = title}, Content = {Content = content}};
            // Set the title and content of the entry.
            // Set a location for the event.
            Where eventLocation = new Where {ValueString = where};
            entry.Locations.Add(eventLocation);

            When eventTime = new When(when, when);
            eventTime.AllDay = true;
            entry.Times.Add(eventTime);            
            // Send the request and receive the response:
            CalendarService service = GetService();            
            service.Insert(new Uri(URI), entry);                
        }

        public delegate void AsyncMethodCaller(string title, string content, string where, DateTime when);


        public void DeleteEvent(DateTime date)
        {
            
        }

    }
}
