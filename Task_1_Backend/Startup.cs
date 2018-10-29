using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Task_1_Backend.DataBase;
using Task_1_Backend.Models;
using Task_1_Backend.Repositories;
using Task_1_Backend.Services.CommentsService;
using Task_1_Backend.Services.PostService;
using AutoMapper;
using Task_1_Backend.Services.CommentsService.Mapper;
using Task_1_Backend.Services.PostService.Mapper;

namespace Task_1_Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //neihardkodint connectionstringo - jo vieta prie appsettings 
            services.AddDbContext<MainDbContext>(options =>
                options.UseSqlite("Data Source=myDb.db"));

            services.AddMvc();

            ConfigureAutoMapper(services);

            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IRepository<Post>, PostRepository>();
            services.AddScoped<IRepository<Comment>, CommentRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseMvc();
        }

        private static void ConfigureAutoMapper(IServiceCollection services)
        {
           // services.AddAutoMapper(typeof(Startup));

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PostProfile());
                cfg.AddProfile(new CommentProfile());

            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
