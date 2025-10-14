
using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_BusinessLayer.Concrete;
using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Context;
using BlogStore_NTIER_AI_DataAccessLayer.EntityFramework;
using BlogStore_NTIER_AI_EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogStore_NTIER_AI_BusinessLayer.Container
{
   public static class Extension
    {
        public static IServiceCollection ContainerDependencies(this IServiceCollection services, IConfiguration configuration)
        {



            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScoped<IArticleDal, EfArticleDal>();

            services.AddScoped<ITagService, TagManager>();
            services.AddScoped<ITagDal, EfTagDal>();

            services.AddScoped<IArticleTagService, ArticleTagManager>();
            services.AddScoped<IArticleTagDal, EfArticleTagDal>();

            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<IAuthorDal, EfAuthorDal>();

            services.AddDbContext<BlogContext>();

            services.AddIdentity<AppUser, IdentityRole>()
                   .AddEntityFrameworkStores<BlogContext>();
            services.AddDbContext<BlogContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

         

            return services;
        }
    }
}
