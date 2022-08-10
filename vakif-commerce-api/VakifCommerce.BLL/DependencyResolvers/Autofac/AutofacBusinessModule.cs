using Autofac;
using Core.Utilities.Security.Jwt;
using VakifCommerce.BLL.Abstract;
using VakifCommerce.BLL.Concrete;
using VakifCommerce.DAL.Abstract;
using VakifCommerce.DAL.Concrete.EntityFramework;

namespace VakifCommerce.BLL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<ProductSpecsManager>().As<IProductSpecsService>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<EfProductDAL>().As<IProductDAL>();
            builder.RegisterType<EfCategoryDAL>().As<ICategoryDAL>();
            builder.RegisterType<EfProductSpecsDAL>().As<IProductSpecsDAL>();
            builder.RegisterType<EfUserDAL>().As<IUserDAL>();

            builder.RegisterType<JWTHelper>().As<ITokenHelper>();

        }
    }
}
