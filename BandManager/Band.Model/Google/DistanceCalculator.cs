using System.Collections.Generic;
using System.Xml;
using Band.Model.Exceptions;
using Band.Model.Internet;

namespace Band.Model.Google
{
    public class DistanceCalculator
    {
        private const string BasicUrl = @"http://maps.googleapis.com/maps/api/distancematrix/xml";
        private const string SWITCHES = @"&mode=driving&language=pl-PL&sensor=false";
        private readonly List<string> _locations = new List<string>();
        private readonly MyHttpResponse _httpResponse = null;
        private GoogleDistanceMatrixResponseParser _parser = null;

        public DistanceCalculator(MyHttpResponse httpResponse)
        {
            _httpResponse = httpResponse;
        }
        
        public void AddLocation(string location)
        {
            location = location.Replace(" ", "+");
            _locations.Add(location);
            _parser = null;
        }

        public List<string>  Locations
        {
            get
            {
                return new List<string>(_locations);
            }
        }

        private string BuildGoogleRequestString()
        {
            string origins = string.Empty;
            string destinations = string.Empty;
            for(int i = 0; i < _locations.Count - 1; ++i)
            {
                string origin = _locations[i];
                origins += origin + "|";
                string destination = _locations[i + 1];
                destinations += destination + "|";
            }
            if (!string.IsNullOrEmpty(origins))
                origins = origins.Remove(origins.Length - 1);
            if (!string.IsNullOrEmpty(destinations))
                destinations = destinations.Remove(destinations.Length - 1);

            return BasicUrl + "?origins=" + origins + "&destinations=" + destinations + SWITCHES;
        }

        private GoogleDistanceMatrixResponseParser CreateResponseParser()
        {

            if (_parser == null)
            {
                string requestUrl = BuildGoogleRequestString();
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(_httpResponse.SendRequest("", requestUrl));
                xmlDocument.Save("C:\\Temp\\Response.xml");
                _parser = new GoogleDistanceMatrixResponseParser(xmlDocument);
                if (!_parser.IsStatusOK())
                    throw new GoogleDistanceMatrixRequestException(requestUrl, _parser.GetStatus());
            }
            return _parser;
        }

        virtual public long CalculateDistance()
        {

            return CreateResponseParser().GetDistance();        
        }

        public List<KeyValuePair<string, string>> GetDestinations()
        {
            return CreateResponseParser().GetDestinations();
        }
    }
}
