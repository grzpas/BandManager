using System.Collections.Generic;
using System.Linq;
using Band.Model.HtmlTemplates;

namespace Band.Model.Google
{
    public class HtmlGoogleMapsRequestGenerator
    {
        public enum Template
        {
            Small,
            Big
        };
        private readonly GoogleMapParams _mapParams;                
        public HtmlGoogleMapsRequestGenerator(GoogleMapParams mapParams)
        {
            _mapParams = mapParams;                 
        }
                        
        private string GetFirstLocation()
        {
            if (!_mapParams.Locations.Any())
                return PBDistanceCalculator.ORIGIN;

            return _mapParams.Locations.First();
        }

        private string GetLastLocation()
        {
            if (!_mapParams.Locations.Any())
                return PBDistanceCalculator.ORIGIN;

            return _mapParams.Locations.Last();
        }

        private string GetWayPoints()
        {
            string result = string.Empty;
            if (_mapParams.Locations.Count() > 2)
            {
                var locations = new List<string>(_mapParams.Locations);
                for (int i = 1; i < locations.Count - 1; ++i)
                {
                    result += "<option value='" + locations[i] + "'></option>";
                }
            }

            return result;
        }

        public string Generate(Template template)
        {
            string sTemplate = (template == Template.Small) ? GoogleRouteTemplate.SmallTemplate : GoogleRouteTemplate.Template;
            string htmlContent = sTemplate.Replace("{##origin##}", "'" + GetFirstLocation() + "'");
            htmlContent = htmlContent.Replace("{##destination##}", "'" + GetLastLocation() + "'");
            htmlContent = htmlContent.Replace("{##waypoints##}", GetWayPoints());
            htmlContent = htmlContent.Replace("{##nohighways##}", _mapParams.AvoidHighways.ToString().ToLower());
            htmlContent = htmlContent.Replace("{##notolls##}", _mapParams.AvoidTolls.ToString().ToLower());
            htmlContent = htmlContent.Replace("{##optimize##}", _mapParams.Optimize.ToString().ToLower());

            return htmlContent;
        }
    }
}
