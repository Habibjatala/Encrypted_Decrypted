namespace Encrypted_Decrypted.DTOs.User
{
    public class UserAuthenticatedDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
    }
}
