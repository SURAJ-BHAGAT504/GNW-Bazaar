namespace GNW_Bazzar.Dto
{
    public class ValidateOtpDto
    {
        public long UserId { get; set; }
        public string? Otp { get; set; }
        public string? Purpose { get; set; }
    }
}
