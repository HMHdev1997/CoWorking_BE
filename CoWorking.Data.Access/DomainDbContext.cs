using CoWorking.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoWorking.Data.Access
{
    public class DomainDbContext : DbContext
    {
        public readonly IConfiguration Configuration;
        public DomainDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<Customer> Customers { set; get; }
        public DbSet<Booking> Bookings { set; get; }
        public DbSet<BookingDetail> BookingDetails { set; get; }
        public DbSet<Device> Devices { set; get; }
        public DbSet<Service> Services { set; get; }
        public DbSet<ServiceDetail> ServiceDetails { set; get; }
        public DbSet<Office> Offices { set; get; }
        public DbSet<Space> Spaces { set; get; }
        public DbSet<Area> Areas { set; get; }
        public DbSet<Staff> Staffs { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<FeedBack> FeedBacks { set; get; }
        public DbSet<Manager> Managers { set; get; }
        public DbSet<CategoryOffice> CategoryOffices { set; get; }
        public DbSet<CategorySpace> CategorySpaces { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Customer
            
            #endregion

        }
    }
}
