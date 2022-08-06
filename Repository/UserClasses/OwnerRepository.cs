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
    }
}