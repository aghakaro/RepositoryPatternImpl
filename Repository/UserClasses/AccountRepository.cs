using Contracts.Interfaces;
using DataAccess;
using Domain.Entities;

namespace Repository.UserClasses
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}