using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorshipManager.Models {
    public class Song {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        
        public ICollection<ServiceSong> Services { get; set; }
    }
}