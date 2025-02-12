using Microsoft.AspNetCore.Mvc;
using EmailSender.Services;
using System.Threading.Tasks;

[Route("api/email")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly EmailService _emailService;

    public EmailController(EmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost("send")]
   public IActionResult SendEmail([FromBody] EmailRequestModel emailRequest)
{
    if (emailRequest == null)
    {
        return BadRequest("Invalid email request");
    }

    // Your email sending logic
    return Ok("Email sent successfully");
}
}
