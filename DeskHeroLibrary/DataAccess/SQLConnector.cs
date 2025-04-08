using Dapper;
using DeskHeroLibrary.DataAccess;
using DeskHeroLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHeroLibrary
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "DeskHeroIt";
        TeamMemberModel IDataConnection.CreateTeamMember(TeamMemberModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@ProficiencyId", model.ProficiencyId);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeamMember_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("id");

                return model;

            }
        }

        TicketModel IDataConnection.CreateTicket(TicketModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Priority", model.Priority);
                p.Add("@ProficiencyId", model.ProficiencyId);
                p.Add("@TeamMemberAssigned", model.TeamMemberAssigned);
                p.Add("@EstimatedTimeToComplete", model.EstimatedTimeToComplete);
                p.Add("@Description", model.Description);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTickets_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("id");

                return model;
            }
        }

        void IDataConnection.DeleteTeamMember(TeamMemberModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", model.Id);

                    connection.Execute("spTeamMembers_DeleteSelected", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        void IDataConnection.DeleteTicket(TicketModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", model.Id);

                    connection.Execute("spTickets_DeleteSelected", p, commandType: CommandType.StoredProcedure);
                }
            }
        }


        List<TeamMemberModel> IDataConnection.TeamMember_GetAll()
        {
            List<TeamMemberModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamMemberModel>("dbo.spTeamMembers_GetAll").ToList();
            }
            return output;
        }

        List<TicketModel> IDataConnection.Ticket_GetAll()
        {
            List<TicketModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TicketModel>("dbo.spTickets_GetAll").ToList();
            }
            return output;
        }
    }
}
