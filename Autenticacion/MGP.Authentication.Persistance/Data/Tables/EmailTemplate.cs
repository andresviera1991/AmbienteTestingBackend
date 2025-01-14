using MGP.Authentication.Persistance.Data.Tables.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Authentication.Persistance.Data.Tables;

[Table("EmailTemplates")]
public class EmailTemplate : EntityBase
{
    public string EmailHtml { get; set; }
}
