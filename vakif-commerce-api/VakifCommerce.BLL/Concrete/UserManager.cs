using Core.Entities.Concrete;
using VakifCommerce.BLL.Abstract;
using VakifCommerce.DAL.Abstract;

namespace VakifCommerce.BLL.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL) //dependency injection
        {
            _userDAL = userDAL;
        }

        public void Add(User user)
        {
            _userDAL.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDAL.Get(U => U.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDAL.GetClaims(user);
        }
    }
}
