using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHeroLibrary.Models
{
    public class TicketModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Priority { get; set; }

        public int ProficiencyId { get; set; }
        public string TeamMemberAssigned { get; set; }

        public int EstimatedTimeToComplete { get; set; }

        public string Description { get; set; }
    }
}
