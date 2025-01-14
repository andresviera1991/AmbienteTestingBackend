namespace MGP.Audit.CrossCutting.Enum;
#pragma warning disable S2344 
public enum TicketStatusEnum
{
    ONE,
    NEW = 1,
    IN_PROCESS_NEIGHBOR = 2,
    IN_PROCESS_AGENT = 3,
    AWAITING_RESOLUTION = 4,
    CLOSED_DUE_TO_NO_RESPONSE = 5,
    CLOSED_GRANTED = 6,
    CLOSED_DENIED = 7,
    CANCELED = 8
}
