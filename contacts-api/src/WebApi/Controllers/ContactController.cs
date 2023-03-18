using Application.Contacts.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("Completed");
        }
    }
}