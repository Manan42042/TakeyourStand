using System.Data.Common;
using System.Data.Entity;
using Abp.Authorization;
using TakeyourStand.Authorization.AutoGenratedBarcodeType;
using TakeyourStand.Authorization.InventyoryNotification;
using Abp.DynamicEntityProperties;
using Abp.Zero.EntityFramework;
using TakeyourStand.Authorization.Roles;
using TakeyourStand.Authorization.Users;
using TakeyourStand.Migrations.SeedData;
using TakeyourStand.MultiTenancy;

namespace TakeyourStand.EntityFramework
{
    public class TakeyourStandDbContext : AbpZeroDbContext<Tenant, Role, User>
    {


        public DbSet<AutoGenratedBarcodeType> tblAutoGenratedBarcodeType { get; set; }
        public DbSet<InventyoryNotification> tblInventyoryNotification { get; set; }


        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TakeyourStandDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TakeyourStandDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TakeyourStandDbContext since ABP automatically handles it.
         */
        public TakeyourStandDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TakeyourStandDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TakeyourStandDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<AutoGenratedBarcodeType>().ToTable("MstAutoGenratedBarcodeType");
            modelBuilder.Entity<InventyoryNotification>().ToTable("MstInventyoryNotification");



            modelBuilder.Entity<DynamicProperty>().Property(p => p.PropertyName).HasMaxLength(250);
            modelBuilder.Entity<DynamicEntityProperty>().Property(p => p.EntityFullName).HasMaxLength(250);
            
        }
        
    }
}
