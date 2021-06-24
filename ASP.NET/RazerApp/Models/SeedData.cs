using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazerApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazerApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new RazerAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazerAppContext>>()))
            {
                if (context.Cricket.Any())
                {
                    return;
                }
                context.Cricket.AddRange(
                    new Cricket
                    {
                        PlayerNum = 3,
                        PlayerName = "Suresh Raina",
                        Position = "Batsman"
                    },
                    new Cricket
                    {
                        PlayerNum = 7,
                        PlayerName = "MS Dhoni",
                        Position = "Batsman"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
