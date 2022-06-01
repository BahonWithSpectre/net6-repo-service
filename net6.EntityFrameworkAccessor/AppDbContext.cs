using Microsoft.EntityFrameworkCore;
using net6.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net6.EntityFrameworkAccessor
{
    public class AppDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
