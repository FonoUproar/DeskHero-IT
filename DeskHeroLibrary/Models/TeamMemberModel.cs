using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHeroLibrary.Models
{
    public class TeamMemberModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProficiencyId { get; set; }
    }
}
