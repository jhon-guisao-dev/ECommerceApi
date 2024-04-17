namespace ECommerceApi
{
    using ECommerceApi.Data;
    using ECommerceApi.GraphQL.Interfaces.Services;
    using ECommerceApi.GraphQL.Mutations;
    using ECommerceApi.GraphQL.Queries;
    using ECommerceApi.GraphQL.Resolvers;
    using ECommerceApi.GraphQL.Services;
    using ECommerceApi.GraphQL.Types;
    using ECommerceApi.GraphQL.Types.Orders;
    using HotChocolate;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPooledDbContextFactory<DataContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<IProductCategoryServices, ProductCategoryServices>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<IOrderDetailServices, OrderDetailServices>();
            services.AddTransient<ICustomerServices, CustomerServices>();

            services.AddGraphQLServer()
                 .AddQueryType(q => q.Name("Query"))
                 .AddType<ProductQueries>()
                 .AddType<OrderQueries>()
                 .AddType<ProductType>()
                 .AddType<ProductCategoryType>()
                 .AddType<CustomerType>()
                 .AddType<OrderType>()
                 .AddType<OrderDetailType>()
                 .AddType<ProductType>()
                 .AddType<CreateOrderInputType>()
                 .AddType<OrderDetailInputType>()
                 .AddType<OrderDetailsAndTotalPriceType>()
                 .AddMutationType<OrderMutations>()
                 .RegisterService<IProductServices>()
                 .RegisterService<IProductCategoryServices>()
                 .RegisterService<IOrderServices>()
                 .RegisterService<IOrderDetailServices>()
                 .RegisterService<ICustomerServices>()
                 .AddFiltering()
                 .AddSorting();

            services.AddScoped<DbInitializer>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}

