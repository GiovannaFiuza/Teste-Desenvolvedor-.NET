using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteDesenvolvedor.Application.Interfaces;
using TesteDesenvolvedor.Application.Mappings;
using TesteDesenvolvedor.Application.Services;
using TesteDesenvolvedor.Data.Repositories;
using TesteDesenvolvedor.Domain.Interfaces;
using TesteDesenvolvedor.Infra.Ioc.Context;

namespace TesteDesenvolvedor.Infra.Ioc
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
                ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
           

            services.AddScoped<IInscricaoRepository, InscricaoRepository>();
            services.AddScoped<ILeadRepository, LeadRepository>();
            services.AddScoped<IOfertaRepository, OfertaRepository>();
            services.AddScoped<IProcessoSeletivoRepository, ProcessoSeletivoRepository>();

            services.AddScoped<IInscricaoService, InscricaoService>();
            services.AddScoped<ILeadService, LeadService>();
            services.AddScoped<IOfertaService, OfertaService>();
            services.AddScoped<IProcessoSeletivoService, ProcessoSeletivoService>();

            services.AddAutoMapper(typeof(MappingDtoEntity));

            return services;
        }
    }
}
