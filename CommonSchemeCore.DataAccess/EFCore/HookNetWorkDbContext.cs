using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonSchemeCore.BasicDataCenterModels.LearningExperts;

namespace CommonSchemeCore.DataAccess.EFCore
{
    public class HookNetWorkDbContext : DbContext
    {
        public HookNetWorkDbContext(DbContextOptions<HookNetWorkDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LanguageComparisonModel>();
        }
        public DbSet<LanguageComparisonModel> LanguageComparisons { get; set; }
    }
    public class HookNetWorkDbInitializer
    {
        public static void Initialize(HookNetWorkDbContext context)
        {
            context.Database.EnsureCreated();
            //InitializeTable(context);
        }
        /// <summary>
        /// 默认增加数据
        /// </summary>
        /// <param name="context"></param>
        public static void InitializeTable(HookNetWorkDbContext context)
        {
            if (context.LanguageComparisons.Any() == false)
            {
                context.SaveChanges();
            }
        }
    }
}
