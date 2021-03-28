using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PayToWrite.Application.UsersCQRS.Queries.GetAllUsersQuery;
using PayToWrite.Domain;

namespace PayToWrite.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAll()
        {
            var result = await _mediator.Send(new GetAllUsersQuery(), CancellationToken.None);
            return result;
        }
    }
}
