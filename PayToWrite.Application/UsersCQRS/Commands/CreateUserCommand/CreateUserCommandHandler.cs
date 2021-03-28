using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PayToWrite.Persistence;
using PayToWrite.Domain;
using PayToWrite.Application.DTO;
using MediatR;
using AutoMapper;

namespace PayToWrite.Application.UsersCQRS.Commands.CreateUserCommand
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly IRepository<User> _repository;
        public CreateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UsersDTO>());
            var mapper = new Mapper(config);
            var user = mapper.Map<User>(request.UsersDTO);
            await _repository.CreateAsync(user);
            return user.Login;
        }
    }
}
