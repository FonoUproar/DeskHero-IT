using DeskHeroLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHeroLibrary.DataAccess
{
    public interface IDataConnection
    {
        TicketModel CreateTicket(TicketModel model);

        TeamMemberModel CreateTeamMember(TeamMemberModel model);

        void DeleteTicket(TicketModel model);

        void DeleteTeamMember(TeamMemberModel model);
        List<TicketModel> Ticket_GetAll();

        List<TeamMemberModel> TeamMember_GetAll();
    }
}
