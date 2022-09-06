using api_ejercicio.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace api_ejercicio.DataAccess
{
    public class OpenBCContextDB : DbContext
    {
        public OpenBCContextDB(DbContextOptions<OpenBCContextDB> options) : base(options)
        {

        }

        //Agrego DbSets
        public DbSet<User>? Users { get; set; }
    }
}
