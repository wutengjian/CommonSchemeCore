using CommonSchemeCore.BasicDataCenterModels.LearningExperts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.DataAccess.EFCore
{
    public partial class DataCenterDbContext : DbContext
    {
        public DataCenterDbContext(DbContextOptions<DataCenterDbContext> options) : base(options)
        {
        }
        public DataCenterDbContext() : base() { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
