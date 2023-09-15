using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Model
{
    internal class Track
    {
        private string _songName;
        private string _artist;
        private string _songWriter;
        private string _addDate;
        private string _songLength;

        public string SongName { get { return _songName; } set { _songName = value;  } }
        public string Artist { get { return _artist; } set { _artist = value; } }
        public string SongWriter { get { return _songWriter; } set { _songWriter = value; } }
        public string AddDate { get { return _addDate; } set { _addDate = value; } }
        public string SongLength { get {  return _songLength; } set { _songLength = value; } }

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
