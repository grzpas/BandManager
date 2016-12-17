using System;
using System.Collections.Generic;
using System.Net;
using Google.GData.Client;
using Google.YouTube;

namespace Band.Model.Google
{    
    public class PBandYoutube
    {
        public static string DeveloperKey = "AI39si6tEjqxL9xeGfV1W3zwI9P0v-NqSmtxZBg0g2X7qzy79pebMP2c4-BkR5KU3_P-ZOOhSjDNVePN_DsQFxRzLb_4z4fcaQ";
        public static string URI = @"http://gdata.youtube.com/feeds/api/users/progressband/uploads";
        private YouTubeRequestSettings _settings = new YouTubeRequestSettings("ProgressBand", DeveloperKey);
        public PBandYoutube()
        {         
        }

        private WebProxy DefaultProxy()
        {  
            IWebProxy iProxy = WebRequest.DefaultWebProxy;
            var myProxy = new WebProxy(iProxy.GetProxy(new Uri(URI))) { Credentials = CredentialCache.DefaultCredentials, UseDefaultCredentials = true };
            return myProxy;
        }
        public List<string> GetAllVideoLinks()
        {
            var result = new List<string>();
            YouTubeRequest request = new YouTubeRequest(_settings);
            request.Proxy = DefaultProxy();
            Feed<Video> videoFeed = request.Get<Video>(new Uri(URI));
            foreach (var entry in videoFeed.Entries)
            {
                result.Add(entry.WatchPage.AbsoluteUri);
            }
            return result;
        }
    }
}
