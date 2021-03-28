using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using PayToWrite.Application.DTO;

namespace PayToWrite.Application.UsersCQRS.Commands.CreateUserCommand
{
    public class CreateUserCommand:IRequest<string>
    {
        public UsersDTO UsersDTO { get; set; }
    }
}
