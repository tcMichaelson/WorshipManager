using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WorshipManager.Models {
    public class Service {
        public int Id { get; set; }

        [DisplayName("Service/Sermon Title")]
        public string Title { get; set; }

        [DisplayName("Service Date")]
        public DateTime ServiceDate { get; set; }
        
        public ICollection<ServiceSong> Songs { get; set; }
        public ICollection<ServiceUser> User { get; set; }
    }
}