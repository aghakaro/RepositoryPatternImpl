using System.Collections.Generic;
using System.Linq;
using Contracts.Interfaces;
using DataAccess;
using Domain.Entities;

namespace Repository.UserClasses
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return FindAll()
                .OrderBy(ow => ow.Name)
                .ToList();

        }

        public Owner GetOwnerByName(string name)
        {
            return FindByCondition(owner => owner.Name != null && owner.Name.Equals(name)).FirstOrDefault();
        }
    }
}