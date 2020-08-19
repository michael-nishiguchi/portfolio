using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.ProgramView
{
    public class DisplayProgramModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public Models.Program Program { get; set; }

        public DisplayProgramModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? programid)
        {
            var reqUrl = Request.HttpContext.Request;
            programid = int.Parse(reqUrl.Query["id"]);

            if (programid == 0)
            {
                return NotFound();
            }

            Program = await _context.Program.FirstOrDefaultAsync(m => m.ProgramID == programid);
            Program.Participants = await _context.Participant.Where(x => x.ProgramID == Program.ProgramID).ToListAsync();

            if (Program == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}