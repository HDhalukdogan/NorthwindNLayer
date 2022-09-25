namespace Api.DTOs
{
    public class RegisterDto : LoginDto
    {
        public string Email { get; set; }
        public string? City { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
