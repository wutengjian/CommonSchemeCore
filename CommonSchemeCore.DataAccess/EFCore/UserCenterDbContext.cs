using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CommonSchemeCore.UserCenterModels.BusinessArchitecture;
using System.Linq;

namespace CommonSchemeCore.DataAccess.EFCore
{
    public class UserCenterDbContext : DbContext
    {
        public UserCenterDbContext(DbContextOptions<UserCenterDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>();
            //modelBuilder.Entity<UserMagneticCorrelationModel>();
            //modelBuilder.Entity<UserDetailsModel>();
            //modelBuilder.Entity<RoleModel>();
            //modelBuilder.Entity<Role_UserInfo>();
            //modelBuilder.Entity<ResourcesModel>();
            //modelBuilder.Entity<Resources_RoleInfo>();
            //modelBuilder.Entity<Resources_OperationPermissionsInfo>();
            //modelBuilder.Entity<OperationPermissionsModel>();
            //modelBuilder.Entity<DepartmentModel>();
            //modelBuilder.Entity<CompanyModel>();
        }
        public DbSet<UserModel> Users { get; set; }
        //public DbSet<UserMagneticCorrelationModel> UserMagneticCorrelations { get; set; }
        //public DbSet<UserDetailsModel> UserDetails { get; set; }
        //public DbSet<RoleModel> Roles { get; set; }
        //public DbSet<Role_UserInfo> Role_Users { get; set; }
        //public DbSet<ResourcesModel> Resources { get; set; }
        //public DbSet<Resources_RoleInfo> Resources_Roles { get; set; }
        //public DbSet<Resources_OperationPermissionsInfo> Resources_OperationPermissions { get; set; }
        //public DbSet<OperationPermissionsModel> OperationPermissions { get; set; }
        //public DbSet<DepartmentModel> Departments { get; set; }
        //public DbSet<CompanyModel> Companys { get; set; }
    }

    public class UserCenterDbInitializer
    {
        public static void Initialize(UserCenterDbContext context)
        {
            context.Database.EnsureCreated();
            InitializeTable(context);
        }
        public static void InitializeTable(UserCenterDbContext context)
        {
            if (context.Users.Any() == false)
            {
                var UserInfos = new UserModel[] {
                     new UserModel() { UserName="JiannyWu", UserPassword="wutj123", DataState=1 },
                     new UserModel() { UserName="admin", UserPassword="123", DataState=1 }
                };
                foreach (var model in UserInfos)
                {
                    context.Users.Add(model);
                }
                context.SaveChanges();
            }
        }
    }
}
