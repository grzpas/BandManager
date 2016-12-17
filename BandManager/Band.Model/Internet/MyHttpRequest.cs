using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace Band.Model.Internet
{
    public class MyHttpRequest
    {
        private readonly string _userName;
        private readonly string _userPwd;
        private readonly string _proxyServer;
        private readonly int _proxyPort;
        private readonly string _request;

        public MyHttpRequest(string HttpUserName, string HttpUserPwd, string HttpProxyServer, int HttpProxyPort,
                             string HttpRequest)
        {
            _userName = HttpUserName;
            _userPwd = HttpUserPwd;
            _proxyServer = HttpProxyServer;
            _proxyPort = HttpProxyPort;
            _request = HttpRequest;
        }

        public virtual HttpWebRequest CreateWebRequest(string uri, NameValueCollection collHeader, string RequestMethod,
                                                       bool NwCred)
        {
            var webrequest = (HttpWebRequest) WebRequest.Create(uri);
            webrequest.KeepAlive = false;
            webrequest.Method = RequestMethod;

            int iCount = collHeader.Count;
            string key;
            string keyvalue;

            for (int i = 0; i < iCount; i++)
            {
                key = collHeader.Keys[i];
                keyvalue = collHeader[i];
                webrequest.Headers.Add(key, keyvalue);
            }

            webrequest.ContentType = "text/html";
            //"application/x-www-form-urlencoded";
            if (_proxyServer.Length > 0)
            {
                webrequest.Proxy = new WebProxy(_proxyServer, _proxyPort);
            }
            webrequest.AllowAutoRedirect = false;

            if (NwCred)
            {
                var wrCache = new CredentialCache();
                wrCache.Add(new Uri(uri), "Basic", new NetworkCredential(_userName, _userPwd));
                webrequest.Credentials = wrCache;
            }
            //Remove collection elements

            collHeader.Clear();
            return webrequest;
        }

        public virtual string GetRedirectURL(HttpWebResponse webresponse, ref string Cookie)
        {
            string uri = "";

            WebHeaderCollection headers = webresponse.Headers;

            if ((webresponse.StatusCode == HttpStatusCode.Found) || (webresponse.StatusCode == HttpStatusCode.Redirect) ||
                (webresponse.StatusCode == HttpStatusCode.Moved) ||
                (webresponse.StatusCode == HttpStatusCode.MovedPermanently))
            {
                // Get redirected uri

                uri = headers["Location"];
                uri = uri.Trim();
            }

            //Check for any cookies

            if (headers["Set-Cookie"] != null)
            {
                Cookie = headers["Set-Cookie"];
            }          
            return uri;
        }

        public virtual string GetFinalResponse(string ReUri, string Cookie, string RequestMethod, bool NwCred)
        {
            var collHeader = new NameValueCollection();
            if (Cookie.Length > 0)
            {
                collHeader.Add("Cookie", Cookie);
            }
            HttpWebRequest webrequest = CreateWebRequest(ReUri, collHeader, RequestMethod, NwCred);
            BuildReqStream(ref webrequest);
            HttpWebResponse webresponse;
            webresponse = (HttpWebResponse) webrequest.GetResponse();
            Encoding enc = Encoding.GetEncoding(1250);
            var loResponseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string Response = loResponseStream.ReadToEnd();
            loResponseStream.Close();
            webresponse.Close();
            return Response;
        }

        private void BuildReqStream(ref HttpWebRequest webrequest) //This method build the request stream for WebRequest
        {
            byte[] bytes = Encoding.ASCII.GetBytes(_request);
            webrequest.ContentLength = bytes.Length;
            Stream oStreamOut = webrequest.GetRequestStream();
            oStreamOut.Write(bytes, 0, bytes.Length);
            oStreamOut.Close();
        }
    }
}
