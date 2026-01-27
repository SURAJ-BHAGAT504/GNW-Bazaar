namespace GNW_Bazzar.Dto
{
    public class ForgotPasswordDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Purpose { get; set; } = "ForgotPassword";
    }
}
