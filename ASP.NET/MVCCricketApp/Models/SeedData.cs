using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCCricketApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCricketApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new MVCCricketAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVCCricketAppContext>>()))
            {
                if (context.Cricket.Any())
                {
                    return;
                }
                context.Cricket.AddRange(
                    new Cricket
                    {
                        PlayerNum = 3,
                        PlayerName="Suresh Raina",
                        Position="Batsman"
                    }
                    ) ;
                context.SaveChanges();
            }
        }


    }
}
