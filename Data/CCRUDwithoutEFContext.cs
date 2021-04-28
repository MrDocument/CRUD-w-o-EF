using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CCRUDwithoutEF.Models;

namespace CCRUDwithoutEF.Data
{
    public class CCRUDwithoutEFContext : DbContext
    {
        public CCRUDwithoutEFContext (DbContextOptions<CCRUDwithoutEFContext> options)
            : base(options)
        {
        }

        public DbSet<CCRUDwithoutEF.Models.BookViewModel> BookViewModel { get; set; }
    }
}
