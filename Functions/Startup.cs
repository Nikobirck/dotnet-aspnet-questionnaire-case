using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using ApplicationCore.Interfaces;
using Infrastructure.Services;

[assembly: FunctionsStartup(typeof(Functions.Startup))]
namespace Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddLogging();

            var db = new MockDatabase();
            builder.Services.AddScoped<IDatabaseConnection>((s) => {
                return db;
            });
            builder.Services.AddScoped<IQuestionaireService>((s) => {
                return new QuestionaireService(db);
            });

        }
    }
}
