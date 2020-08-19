using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Participant
    {
        //primary key
        public int ParticipantID { get; set; }

        [Display(Name = "Full Name")]
        public string FullNameOfParticipant { get; set; }

        public string TalkSubject { get; set; }

        public string ParticipantTitle { get; set; }

        public string ParticipantRole { get; set; }

        public int ProgramID { get; set; }

    }
}
