using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DataAccessLayer.Mapping;


namespace DataAccessLayer
{
    public class ManagementContext :DbContext
    {
        public ManagementContext():base("TaskManagementDb")
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Status>  Statuses{ get; set; }
        public DbSet<EntitiesLayer.Task> Tasks { get; set; }
        public DbSet<EntitiesLayer.Type> Types { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContactMap());
            //modelBuilder.Configurations.Add(new CustomerMap());
            //modelBuilder.Configurations.Add(new EmployeeMap());
            //modelBuilder.Configurations.Add(new ProjectMap());
            //modelBuilder.Configurations.Add(new RoleMap());
            //modelBuilder.Configurations.Add(new StatusMap());
            //modelBuilder.Configurations.Add(new TaskMap());
            //modelBuilder.Configurations.Add(new TypeCode());
            //modelBuilder.Configurations.Add(new UserMap());
            base.OnModelCreating(modelBuilder);
        }
    }

}
