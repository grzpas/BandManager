﻿namespace Band.Model.Entities
{
    public class Song
    {
        public virtual int Type { get; set; }
        public virtual string Title { get; set; }
        public virtual string Scale { get; set;}
        public virtual string Chords { get; set; }
    }
}
