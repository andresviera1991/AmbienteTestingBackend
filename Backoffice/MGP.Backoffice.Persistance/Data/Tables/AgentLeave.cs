using MGP.Backoffice.Persistance.Data.Tables.Base;
using MGP.Backoffice.Persistence.Data.Tables;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Backoffice.Persistance.Data.Tables
{
    public class AgentLeave : EntityBaseGuid
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("Agent")]
        public Guid AgentId { get; set; }
        public virtual User Agent { get; set; }
    }
}
