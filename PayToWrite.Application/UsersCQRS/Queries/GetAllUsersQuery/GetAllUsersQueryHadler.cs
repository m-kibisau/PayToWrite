using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PayToWrite.Persistence;
using PayToWrite.Domain;

namespace PayToWrite.Application.UsersCQRS.Queries.GetAllUsersQuery
{
    public class GetAllUsersQueryHadler : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
    {
        private readonly IRepository<User> _usersRepository;
        public GetAllUsersQueryHadler(IRepository<User> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return _usersRepository.GetAllAsync();
        }
    }
}
