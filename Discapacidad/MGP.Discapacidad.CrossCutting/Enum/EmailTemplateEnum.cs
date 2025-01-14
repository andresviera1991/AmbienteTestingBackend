using Ardalis.SmartEnum;
namespace MGP.Discapacidad.CrossCutting.Enum;
public class EmailTemplateEnum : SmartEnum<EmailTemplateEnum, int>
{
    public EmailTemplateEnum(string name, int value) : base(name, value)
    {
    }

    public static readonly EmailTemplateEnum NONE = new(nameof(NONE), 0);
    public static readonly EmailTemplateEnum CREATE_CUD = new(nameof(CREATE_CUD), 1);
    public static readonly EmailTemplateEnum CREATE_SUBE = new(nameof(CREATE_SUBE), 2);
    public static readonly EmailTemplateEnum CREATE_PARKING = new(nameof(CREATE_PARKING), 3);
    public static readonly EmailTemplateEnum NEW_TICKET_ACTIVITY = new(nameof(NEW_TICKET_ACTIVITY), 4);
}
