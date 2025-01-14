namespace MGP.Audit.CrossCutting.Enum;

#pragma warning disable S2344 
public enum DocumentStatusEnum
{
    NONE,
    PENDING_VALIDATION = 1,
    VALID = 2,
    INVALID = 3,
    DELETED = 4
}
