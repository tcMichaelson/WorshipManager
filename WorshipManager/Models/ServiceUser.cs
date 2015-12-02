using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WorshipManager.Models {
    public class ServiceUser {
        public int Id { get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}