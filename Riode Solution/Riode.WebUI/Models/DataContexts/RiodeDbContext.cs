using Microsoft.EntityFrameworkCore;
using Riode.WebUI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riode.WebUI.Models.DataContexts
{
    public class RiodeDbContext : DbContext
    {
        public RiodeDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
