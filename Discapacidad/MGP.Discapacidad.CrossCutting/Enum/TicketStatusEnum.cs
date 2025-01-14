using Ardalis.SmartEnum;

namespace MGP.Discapacidad.CrossCutting.Enum;
#pragma warning disable S2344 
public class TicketStatusEnum : SmartEnum<TicketStatusEnum, int>
{
    public TicketStatusEnum(string name, int value) : base(name, value)
    {
    }

    public static readonly TicketStatusEnum NONE = new (nameof(NONE), 0);
    public static readonly TicketStatusEnum NEW = new (nameof(NEW), 1);
    public static readonly TicketStatusEnum IN_PROCESS_NEIGHBOR = new (nameof(IN_PROCESS_NEIGHBOR), 2);
    public static readonly TicketStatusEnum IN_PROCESS_AGENT = new (nameof(IN_PROCESS_AGENT), 3);
    public static readonly TicketStatusEnum AWAITING_RESOLUTION = new (nameof(AWAITING_RESOLUTION), 4);
    public static readonly TicketStatusEnum CLOSED_DUE_TO_NO_RESPONSE = new (nameof(CLOSED_DUE_TO_NO_RESPONSE), 5);
    public static readonly TicketStatusEnum CLOSED_GRANTED = new(nameof(CLOSED_GRANTED), 6);
    public static readonly TicketStatusEnum CLOSED_DENIED = new(nameof(CLOSED_DENIED), 7);
    public static readonly TicketStatusEnum CANCELED = new(nameof(CANCELED), 8);
}
