using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VakifCommerce.DAL.Abstract;
using VakifCommerce.DAL.Concrete.EntityFramework.Contexts;
using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.DAL.Concrete.EntityFramework
{
    public class EfProductDAL : IProductDAL
    {
        public void Add(Product entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var addedEntitiy = context.Entry(entity);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var deletedEntitiy = context.Entry(entity);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (var context = new VakifCommerceContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetList(Expression<Func<Product, bool>>? filter = null)
        {
            using (var context = new VakifCommerceContext())
            {
                var ctr = context.Product;
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
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
