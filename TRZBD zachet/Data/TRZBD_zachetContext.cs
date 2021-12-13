using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRZBD_zachet.Models;

namespace TRZBD_zachet.Data
{
    public class TRZBD_zachetContext : DbContext
    {
        public TRZBD_zachetContext (DbContextOptions<TRZBD_zachetContext> options)
            : base(options)
        {
        }

        public DbSet<TRZBD_zachet.Models.Class1> Class1 { get; set; }
    }
}
