using Financial.Data.Mapping.FinanceAccounts;
using Financial.Data.Mapping.PaymentTerms;
using Financial.Domain.Entities.FinanceAccounts;
using Financial.Domain.Entities.PaymentTerms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Financial.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<FinanceAccountsEntity> FinanceAccounts { get; set; }
        
        public DbSet<FinanceAccountsItemsEntity> FinanceAccountsItems { get; set; }

        public DbSet<FinanceAccountsPaymentItemsEntity> FinanceAccountsPaymentItems { get; set; }

        public DbSet<PaymentTermsEntity> PaymentTerms { get; set; }

        public DbSet<PaymentTermsItemsEntity> PaymentTermsItems { get; set; }

        public MyContext([NotNullAttribute] DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FinanceAccountsEntity>(new FinanceAccountMap().Configure);
            modelBuilder.Entity<FinanceAccountsItemsEntity>(new FinanceAccountsItemsMap().Configure);
            modelBuilder.Entity<FinanceAccountsPaymentItemsEntity>(new FinanceAccountsPaymentItemsMap().Configure);
            modelBuilder.Entity<PaymentTermsEntity>(new PaymentTermsMap().Configure);
            modelBuilder.Entity<PaymentTermsItemsEntity>(new PaymentTermsItemsMap().Configure);


            //wil not be used - Only when i want to create initials content

            //modelBuilder.Entity<FinanceAccountEntity>().HasData(
            //        new FinanceAccountEntity() 
            //        {
            //            Id = Guid.NewGuid(),
            //            CreateAt = DateTime.Now,
            //        }
            //    );

            var paymentTermsId = Guid.NewGuid();
            var companyId = Guid.NewGuid();
            modelBuilder.Entity<PaymentTermsEntity>().HasData(
                new PaymentTermsEntity()
                {
                    Id = Guid.NewGuid(),
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    Description = "Á vista",
                    CompanyId = companyId
                }
            );

            modelBuilder.Entity<PaymentTermsEntity>().HasData(
                new PaymentTermsEntity()
                {
                    Id = paymentTermsId,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    Description = "30 dias",
                    CompanyId = companyId
                }
            );

            modelBuilder.Entity<PaymentTermsItemsEntity>().HasData(
                new PaymentTermsItemsEntity()
                {
                    Id = Guid.NewGuid(),
                    CreateAt = DateTime.Now,
                    UpdateAt= DateTime.Now,
                    PaymentTermsId = paymentTermsId,
                    Days = 30,
                    CompanyId = companyId
                }
            );
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
