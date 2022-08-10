using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VakifCommerce.DAL.Abstract;
using VakifCommerce.DAL.Concrete.EntityFramework.Contexts;

namespace VakifCommerce.DAL.Concrete.EntityFramework
{
    public class EfUserDAL : IUserDAL
    {
        public void Add(User entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var addedEntitiy = context.Entry(entity);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var deletedEntitiy = context.Entry(entity);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (var context = new VakifCommerceContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new VakifCommerceContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }

        public List<User> GetList(Expression<Func<User, bool>>? filter = null)
        {
            using (var context = new VakifCommerceContext())
            {
                var ctr = context.Category;
                return filter == null ? context.Set<User>().ToList() : context.Set<User>().Where(filter).ToList();
            }
        }

        public void Update(User entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var updatedEntitiy = context.Entry(entity);
                updatedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
