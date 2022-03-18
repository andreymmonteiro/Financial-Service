using Financial.Data.Mapping.FinanceAccounts;
using Financial.Domain.Entities.FinanceAccounts;
using Microsoft.EntityFrameworkCore;

namespace Financial.Data.Context
{
    public class MyContext : DbContext
    {
        
        public MyContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FinanceAccount>(new FinanceAccountMap().Configure);

            //wil not be used - Only when i want to create initials content

            //modelBuilder.Entity<FinanceAccountEntity>().HasData(
            //        new FinanceAccountEntity() 
            //        {
            //            Id = Guid.NewGuid(),
            //            CreateAt = DateTime.Now,
            //        }
            //    );

            base.OnModelCreating(modelBuilder);
        }
    }
}
