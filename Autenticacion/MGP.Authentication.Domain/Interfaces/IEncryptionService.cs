namespace MGP.Authentication.Domain.Interfaces
{
    public interface IEncryptionService
    {
        public string HashPassword(string password);
        public bool VerifyPassword(string hashedPassword, string password);
    }
}
