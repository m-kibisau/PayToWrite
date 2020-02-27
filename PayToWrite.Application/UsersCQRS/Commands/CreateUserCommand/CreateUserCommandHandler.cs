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
    class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly IRepository<Users> _repository;
        public CreateUserCommandHandler(IRepository<Users> repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Users, UsersDTO>());
            var mapper = new Mapper(config);
            var user = mapper.Map<Users>(request.UsersDTO);
            await _repository.CreateAsync(user);
            return user.Login;
        }
    }
}
