using System.Collections.Generic;

namespace Band.Model.Google
{
    public class GoogleMapParams
    {
        private bool _avoidHighways;
        private bool _avoidTolls;
        private bool _optimize;
        private IEnumerable<string> _locations;

        public GoogleMapParams(bool avoidHighways, bool avoidTolls, bool optimize, IEnumerable<string> locations)
        {
            _avoidHighways = avoidHighways;
            _avoidTolls = avoidTolls;
            _optimize = optimize;
            _locations = locations ?? new List<string>();
        }

        public bool AvoidHighways
        {
            get { return _avoidHighways; }
        }

        public bool AvoidTolls
        {
            get { return _avoidTolls; }
        }

        public bool Optimize
        {
            get { return _optimize; }
        }

        public IEnumerable<string> Locations
        {
            get {return _locations;}            
        }
    }
}