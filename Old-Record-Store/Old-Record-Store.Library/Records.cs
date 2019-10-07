using System;
using System.Collections.Generic;
using System.Text;

namespace Old_Record_Store.Library
{
    class Records
    {
        List<Records> inventory = new List<Records>();


        public Records(string song, string artist, string releasedate, string format, int stock)
        {
            Song = song;
            Artist = artist;
            ReleaseDate = releasedate;
            Format = format;
            Stock = stock;
        }

        public string Song { get; set; }
        public string Artist { get; set; }
        public string ReleaseDate { get; set; }
        public string Format { get; set; }
        public int Stock { get; set; }


    }
}
