using Core.DataAccess;
using Core.Entities.Concrete;

namespace VakifCommerce.DAL.Abstract
{
    public interface IUserDAL : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
