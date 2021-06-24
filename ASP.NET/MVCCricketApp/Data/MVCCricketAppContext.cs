using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCricketApp.Models;

namespace MVCCricketApp.Data
{
    public class MVCCricketAppContext : DbContext
    {
        public MVCCricketAppContext (DbContextOptions<MVCCricketAppContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCricketApp.Models.Cricket> Cricket { get; set; }
    }
}
