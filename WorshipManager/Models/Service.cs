using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorshipManager.Models {
    public class Service {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ServiceDate { get; set; }
        
        public ICollection<ServiceSong> Songs { get; set; }
        public ICollection<ServiceUser> User { get; set; }
    }
}