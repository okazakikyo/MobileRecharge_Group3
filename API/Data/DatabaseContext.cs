using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext (DbContextOptions options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<PostPaid> PostPaid { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<ChargeList> ChargeList { get; set; }
        public DbSet<Paypal> Paypal { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }
}
