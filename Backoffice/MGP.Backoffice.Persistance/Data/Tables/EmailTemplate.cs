using MGP.Backoffice.Persistance.Data.Tables.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Backoffice.Persistance.Data.Tables;

[Table("EmailTemplates")]
public class EmailTemplate : EntityBase
{
    public string EmailHtml { get; set; }
}
