using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Program
    {
        public int ProgramID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime DateOfMeeting { get; set; }

        [Display(Name = "Opening Song")]
        public string OpeningSong { get; set; }


        [Display(Name = "Sacrament Song")]
        public string SacramentHymn { get; set; }

        public List<Participant> Participants { get; set; }


        [Display(Name = "Closing Song")]
        public string ClosingSong { get; set; }
    }
}
