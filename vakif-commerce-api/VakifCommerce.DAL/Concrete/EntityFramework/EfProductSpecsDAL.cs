using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VakifCommerce.DAL.Abstract;
using VakifCommerce.DAL.Concrete.EntityFramework.Contexts;
using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.DAL.Concrete.EntityFramework
{
    public class EfProductSpecsDAL : IProductSpecsDAL
    {
        public void Add(ProductSpecs entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var addedEntitiy = context.Entry(entity);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(ProductSpecs entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var deletedEntitiy = context.Entry(entity);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ProductSpecs Get(Expression<Func<ProductSpecs, bool>> filter)
        {
            using (var context = new VakifCommerceContext())
            {
                return context.Set<ProductSpecs>().SingleOrDefault(filter);
            }
        }

        public List<ProductSpecs> GetList(Expression<Func<ProductSpecs, bool>>? filter = null)
        {
            using (var context = new VakifCommerceContext())
            {
                var ctr = context.ProductsSpecs;
                return filter == null ? context.Set<ProductSpecs>().ToList() : context.Set<ProductSpecs>().Where(filter).ToList();
            }
        }

        public void Update(ProductSpecs entity)
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
