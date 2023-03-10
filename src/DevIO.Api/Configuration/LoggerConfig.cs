using DevIO.Api.Extensions;

namespace DevIO.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "0a0427673bb94160bafa8055e0739896";
                o.LogId = new Guid("b11bd3e9-68b6-4973-9aec-f69899ddf882");
            });

            services.AddHealthChecks()
                .AddElmahIoPublisher(options =>
                {
                    options.ApiKey = "0a0427673bb94160bafa8055e0739896";
                    options.LogId = new Guid("b11bd3e9-68b6-4973-9aec-f69899ddf882");
                    options.HeartbeatId = "API Fornecedores";

                })
               .AddCheck("Produtos", new SqlServerHealthCheck(configuration.GetConnectionString("DefaultConnection")))
               .AddSqlServer(configuration.GetConnectionString("DefaultConnection"), name: "BancoSQL");

            services.AddHealthChecksUI()
                .AddSqlServerStorage(configuration.GetConnectionString("DefaultConnection"));

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }
    }
}