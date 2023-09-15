using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Model
{
    internal class Track
    {
        private string songName;
        private string artist;
        private string songWriter;
        private string addDate;
        private string songLength;

        public string SongName { get { return songName; } set { songName = value;  } }
        public string Artist { get { return artist; } set { artist = value; } }
        public string SongWriter { get { return songWriter; } set { songWriter = value; } }
        public string AddDate { get { return addDate; } set { addDate = value; } }
        public string SongLength { get {  return songLength; } set { songLength = value; } }

        // god morgen

        #region constructor

        private Track() { }

        private Track(string SN): this()
        {
            SN = SongName;
        }

        private Track(string SN, string A): this(SN)
        {
            A = Artist;
        }

        private Track(string SN, string A, string SW) : this(SN, A)
        {
            SW = songWriter;
        }

        private Track(string SN, string A, string SW, string AD) : this(SN, A, SW)
        {
            AD = AddDate;
        }

        public Track(string SN, string A, string SW, string AD, string SL) : this(SN, A, SW, AD)
        {
            SL = SongLength;
        }

        #endregion

    }
}
