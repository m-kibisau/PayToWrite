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
    class GetAllUsersQueryHadler : IRequestHandler<GetAllUsersQuery, IEnumerable<Users>>
    {
        private readonly IRepository<Users> _usersRepository;
        public GetAllUsersQueryHadler(IRepository<Users> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public Task<IEnumerable<Users>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return _usersRepository.GetAllAsync();
        }
    }
}
