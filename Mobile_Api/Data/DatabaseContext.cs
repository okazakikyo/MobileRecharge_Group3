using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DbClass;
using Microsoft.EntityFrameworkCore;
namespace Mobile_Api.Data
{
    public class DatabaseContext    : DbContext
    {
        public DatabaseContext() :base(){}
        public DbSet<User> Users { get; set; }
        public DbSet<PostPaid> PostPaids { get; set; }
        public DbSet<Paypal> Paypals { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<ChargeList> ChargeLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string url = "server =.; database =MobileRechargeDB; uid =sa; pwd =123456789";
            optionsBuilder.UseSqlServer(url);
        }
    }
}
