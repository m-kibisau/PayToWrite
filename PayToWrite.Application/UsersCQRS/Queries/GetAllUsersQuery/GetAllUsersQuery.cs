using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using PayToWrite.Domain;

namespace PayToWrite.Application.UsersCQRS.Queries.GetAllUsersQuery
{
    class GetAllUsersQuery : IRequest<IEnumerable<Users>>
    {
    }
}
