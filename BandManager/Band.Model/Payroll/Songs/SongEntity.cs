using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgressBand
{
    public class SongEntity
    {
        private string _entity;

        public SongEntity(string entity)
        {
            _entity = entity;
        }
           
        public new string ToString()
        {
            return _entity;
        }
    }
}
