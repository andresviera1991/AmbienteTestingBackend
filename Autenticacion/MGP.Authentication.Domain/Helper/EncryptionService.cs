using MGP.Authentication.Domain.Interfaces;

namespace MGP.Authentication.Domain.Helper
{
    public class EncryptionService : IEncryptionService
    {
        public virtual string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public virtual bool VerifyPassword(string hashedPassword, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
