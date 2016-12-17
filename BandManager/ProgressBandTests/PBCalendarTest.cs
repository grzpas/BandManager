using System;
using Google.GData.Calendar;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class PBCalendarTest
    {
        [Test]
        public void FirstTest()
        {
            CalendarService service = new CalendarService("ProgressBand");
            //GDataRequestFactory requestFactory = (GDataRequestFactory)service.RequestFactory;
            EventQuery query = new EventQuery();
            query.Uri = new Uri("https://www.google.com/calendar/feeds/progressband@gmail.com/private/full");
            query.FutureEvents = true;
            query.SingleEvents = true;
            query.SortOrder = CalendarSortOrder.ascending;
            query.ExtraParameters = "orderby=starttime";
            query.NumberToRetrieve = 2;
            //IWebProxy iProxy = WebRequest.DefaultWebProxy;
            //WebProxy myProxy = new WebProxy(iProxy.GetProxy(query.Uri));
            // potentially, setup credentials on the proxy here
            //myProxy.Credentials = CredentialCache.DefaultCredentials;
            //myProxy.UseDefaultCredentials = true;
            //requestFactory.Proxy = myProxy;
            service.setUserCredentials("progressband@gmail.com", "yaya2000");                    
            var resultFeed = service.Query(query);            
            foreach (EventEntry entry in resultFeed.Entries)
            {
                string title = entry.Title.Text;
                string locations = string.Empty;                
                foreach (var location in entry.Locations)
                {
                    locations += location.ValueString + " ";
                }
                string description = entry.Content.Content;
                DateTime dateTime = entry.Times[0].StartTime;

            }
        }
    }
}
