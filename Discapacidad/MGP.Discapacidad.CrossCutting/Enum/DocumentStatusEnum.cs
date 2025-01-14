using Ardalis.SmartEnum;
namespace MGP.Discapacidad.CrossCutting.Enum;

public class DocumentStatusEnum : SmartEnum<DocumentStatusEnum, int>
{
    public DocumentStatusEnum(string name, int value) : base(name, value)
    {
    }

    public static readonly DocumentStatusEnum NONE = new(nameof(NONE), 0);
    public static readonly DocumentStatusEnum PENDING_VALIDATION = new(nameof(PENDING_VALIDATION), 1);
    public static readonly DocumentStatusEnum VALID = new(nameof(VALID), 2);
    public static readonly DocumentStatusEnum INVALID = new(nameof(INVALID), 3);
    public static readonly DocumentStatusEnum DELETED = new(nameof(DELETED), 4);
}
