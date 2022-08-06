using System.Collections.Generic;
using Domain.Entities;

namespace Contracts.Interfaces
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        IEnumerable<Owner> GetAllOwners();

        Owner GetOwnerByName(string name);
    }
}
