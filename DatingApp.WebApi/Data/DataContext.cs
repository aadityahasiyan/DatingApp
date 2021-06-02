using System.Data;
using DatingApp.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
namespace DatingApp.WebApi.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppUser> Users{get; set;}
    }   
}