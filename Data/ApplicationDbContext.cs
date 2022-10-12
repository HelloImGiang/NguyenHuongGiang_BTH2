using NguyenHuongGiangBTH2.Models;
using Microsoft.EntityFrameworkCore;

namespace NguyenHuongGiangBTH2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students {get; set;}
        
    }
}