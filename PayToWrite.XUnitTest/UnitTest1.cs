using System;
using System.Collections.Generic;
using Xunit;
using PayToWrite.Application.UsersCQRS.Queries.GetAllUsersQuery;
using MediatR;
using Microsoft.Extensions.Logging;
using PayToWrite.Api.Controllers;
using Moq;
using PayToWrite.Domain;

namespace PayToWrite.XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var mediator = new Mock<IMediator>().Object;
            var logger = new Mock<ILogger<UserController>>().Object;
            var controller = new UserController(logger, mediator);

            var result = await controller.GetAll();

            Assert.IsAssignableFrom<IEnumerable<User>>(result);
        }
    }
}
