using Ardalis.SmartEnum;
namespace MGP.Discapacidad.CrossCutting.Enum;
public class TicketTypeEnum : SmartEnum<TicketTypeEnum, int>
{
    public TicketTypeEnum(string name, int value) : base(name, value)
    {
    }

    public static readonly TicketTypeEnum NONE = new(nameof(NONE), 0);
    public static readonly TicketTypeEnum CUD = new(nameof(CUD), 1);
    public static readonly TicketTypeEnum SUBE = new(nameof(SUBE), 2);
    public static readonly TicketTypeEnum PARKING = new(nameof(PARKING), 3);
}

