using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net;

namespace GNW_Bazaar.Core.Services
{
    public class MailService(ILogger<MailService> logger, IConfiguration configuration) : IMailService
    {
        public async Task<ResponseDto<object?>> SendOtpByEmail(string email, string otpCode)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("GNW Bazaar Security", configuration["MailSettings:SenderEmail"]));
                message.To.Add(new MailboxAddress("", email));
                message.Subject = $"{otpCode} is your GNW Bazaar verification code";

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = $@"
                <div style='font-family: Arial, sans-serif; border: 1px solid #ddd; padding: 30px; max-width: 500px; margin: auto; text-align: center;'>
                    <h2 style='color: #333;'>Verification Code</h2>
                    <p style='color: #666;'>Your one-time password (OTP) is:</p>
                    <h1 style='color: #007bff; letter-spacing: 10px; font-size: 36px; margin: 20px 0;'>{otpCode}</h1>
                    <p style='color: #666;'>This code expires in 5 minutes. Do not share it with anyone.</p>
                    <hr style='border: 0; border-top: 1px solid #eee; margin: 20px 0;'>
                    <p style='font-size: 12px; color: #999;'>This is a system-generated email. Please do not reply to this message.</p>
                </div>"
                };
                message.Body = bodyBuilder.ToMessageBody();

                using var client = new SmtpClient();
                await client.ConnectAsync(configuration["MailSettings:Host"], int.Parse(configuration["MailSettings:Port"]), false);
                await client.AuthenticateAsync(configuration["MailSettings:SenderEmail"], configuration["MailSettings:Password"]);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);

                return new ResponseDto<object?>
                {
                    ResponseCode = 200,
                    Message = "OTP email sent successfully",
                    Value = true
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ClientService.Create");
                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.InnerException?.Message ?? ex.Message,
                    Value = false
                };
            }
        }
    }
}
