namespace MGP.Backoffice.CrossCutting.Enum;

#pragma warning disable S2344
public enum UserStatusEnum
{
    NONE,
    ACTIVE = 1,
    INACTIVE = 2,
    BLOCKED = 3,
    DELETED = 4,
    PASSWORD_RESET_REQUESTED = 5,
    ACCESS_REQUESTED = 6
}
