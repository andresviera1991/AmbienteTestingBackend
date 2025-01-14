using MGP.Authentication.Persistance.Data.Tables.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Authentication.Persistance.Data.Tables;

[Table("PhoneNumber")]
public class PhoneNumber : EntityBaseGuid
{

    public string Number { get; set; }

}
