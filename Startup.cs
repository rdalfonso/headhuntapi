using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using headhuntapi.Models;
using headhuntapi.Services;

namespace headhuntapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)         {             services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
            });             services.AddMvc();              //var connString = $"Data Source=localhost,1401;Initial Catalog=HeadHuntReview;User ID=SA;Password=L@rc0mb3;";             services.AddDbContext<HeadHuntReviewContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HeadHuntReviewsDatabase")));             services.AddScoped<IRecruiterRepository, RecruiterRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICandidateRepository, CandidateRepository>();         } 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseCors(              //  options => options.WithOrigins("http://localhost:4200").AllowAnyMethod()             //);
            app.UseCors("AllowAllHeaders");
            app.UseMvc();
        }
    }
}
