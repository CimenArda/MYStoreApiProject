using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {

        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IFeatureService, FeatureManager>();


            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductService, ProductManager>();
        }





    }
}