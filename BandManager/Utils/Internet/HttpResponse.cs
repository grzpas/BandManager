using System.Collections.Specialized;
using System.Net;

namespace Utils.Internet
{
    public class MyHttpResponse
    {
   
        private string _userName = string.Empty;
        private string _userPwd = string.Empty;
        private string _proxyServer = string.Empty;
        private int _proxyPort = 0;
        private string _requestMethod = "GET";

        public MyHttpResponse(string httpUserName, string httpUserPass, string proxyServer, int proxyPort) //Constructor
        {
            _userName = httpUserName;
            _userPwd = httpUserPass;
            _proxyServer = proxyServer;
            _proxyPort = proxyPort;
        }

        public MyHttpResponse()
        {            
        }

        public string HTTP_USER_NAME
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string HTTP_USER_PASSWORD
        {
            get { return _userPwd; }
            set { _userPwd = value; }
        }

        public string PROXY_SERVER
        {
            get { return _proxyServer; }
            set { _proxyServer = value; }
        }

        public int PROXY_PORT
        {
            get { return _proxyPort; }
            set { _proxyPort = value; }
        }

        public string SendRequest(string pRequest, string pURI)
            /*This public interface receives the request 
            and send the response of type string. */
        {
            string FinalResponse = "";
            string Cookie = "";

            var collHeader = new NameValueCollection();

            HttpWebResponse webresponse;

            var BaseHttp = new HttpRequest(_userName, _userPwd, _proxyServer, _proxyPort, pRequest);
            try
            {
                HttpWebRequest webrequest = BaseHttp.CreateWebRequest(pURI, collHeader, _requestMethod, true);
                webresponse = (HttpWebResponse) webrequest.GetResponse();

                string ReUri = BaseHttp.GetRedirectURL(webresponse, ref Cookie);
                //Check if there is any redirected URI.

                webresponse.Close();
                ReUri = ReUri.Trim();
                if (ReUri.Length == 0) //No redirection URI
                {
                    ReUri = pURI;
                }
                _requestMethod = "POST";
                FinalResponse = BaseHttp.GetFinalResponse(ReUri, Cookie, _requestMethod, true);
            } //End of Try Block
            finally
            {
                BaseHttp = null;
            }
            return FinalResponse;
        }

        //End of SendRequestTo method


        private WebException CatchHttpExceptions(string ErrMsg)
        {
            ErrMsg = "Error During Web Interface. Error is: " + ErrMsg;
            return new WebException(ErrMsg);
        }
    }
}

