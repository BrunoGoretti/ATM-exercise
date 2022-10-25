using Microsoft.EntityFrameworkCore;
using ATM_exercise.Models;

namespace ATM_exercise.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ATMModel> ATM { get; set; }
        //public DbSet<Money> MoneyModel { get; set; }
        //public DbSet<Operator> OperatorModel { get; set; }
        public DbSet<UserModel> User { get; set; }
    }
}
