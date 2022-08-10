using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VakifCommerce.DAL.Abstract;
using VakifCommerce.DAL.Concrete.EntityFramework.Contexts;
using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.DAL.Concrete.EntityFramework
{
    public class EfCategoryDAL : ICategoryDAL
    {
        public void Add(Category entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var addedEntitiy = context.Entry(entity);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (var context = new VakifCommerceContext())
            {
                var deletedEntitiy = context.Entry(entity);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (var context = new VakifCommerceContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetList(Expression<Func<Category, bool>>? filter = null)
        {
            using (var context = new VakifCommerceContext())
            {
                var ctr = context.Category;
                return filter == null ? context.Set<Category>().ToList() : context.Set<Category>().Where(filter).ToList();
            }
        }

        public void Update(Category entity)
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
