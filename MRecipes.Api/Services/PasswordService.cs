using System.Security.Cryptography;
using System.Text;

namespace MRecipes.Api.Services;

public interface IPasswordService
{
    public string EncryptPassword(string password, out string passwordSalt);
    public bool VerifyPassword(string password, string hash, string salt);
}

public class PasswordService : IPasswordService
{
    private const int _keySize = 64;
    private const int _iterations = 350000;
    private readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA512;

    public string EncryptPassword(string password, out string passwordSalt)
    {
        var passwordHash = Convert.ToHexString(CreatePassword(password, out var salt));

        passwordSalt = salt;

        return passwordHash;
    }

    public bool VerifyPassword(string password, string hash, string salt)
    {
        var hashToCompate = HashPassword(password, salt);
        return CryptographicOperations.FixedTimeEquals(hashToCompate, Convert.FromHexString(hash));
    }

    private byte[] CreatePassword(string password, out string salt)
    {
        var random = RandomNumberGenerator.GetBytes(_keySize);
        salt = Encoding.UTF8.GetString(random);

        return HashPassword(password, salt);
    }

    private byte[] HashPassword(string password, string salt)
    {
        return Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(salt).ToArray(), _iterations, _hashAlgorithm, _keySize);
    }
}
