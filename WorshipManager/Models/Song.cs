using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WorshipManager.Models {
    public class Song {
        public int Id { get; set; }

        [DisplayName("Song Title")]
        public string Name { get; set; }

        [DisplayName("Author/Writer")]
        public string Author { get; set; }
        public string Lyrics { get; set; }
        
        public ICollection<ServiceSong> Services { get; set; }
    }
}