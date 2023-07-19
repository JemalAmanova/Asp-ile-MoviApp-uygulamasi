using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
        public DbSet<User> Kullanicilar=>Set<User>();
        public DbSet<Movie>Filmler=>Set<Movie>();
    }
}