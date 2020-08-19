using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public enum ParticipantRoles
    {
        [Description("{Presiding")]
        PresidingLeader,

        [Description("Conducting")]
        ConductingLeader,

        [Description("Opening Prayer")]
        OpeningPrayer,

        Speaker,

        [Description("Closing Prayer")]
        ClosingPrayer
    }
}
