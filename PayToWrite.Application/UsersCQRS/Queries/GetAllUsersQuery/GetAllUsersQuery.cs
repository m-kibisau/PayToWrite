using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using PayToWrite.Domain;

namespace PayToWrite.Application.UsersCQRS.Queries.GetAllUsersQuery
{
    public class GetAllUsersQuery : IRequest<IEnumerable<User>>
    {
    }
}
