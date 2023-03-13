namespace TakeyourStand.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class TYS76 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MstInventyoryNotification",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 300),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId= c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId= c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId= c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InventyoryNotification_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.MstInventyoryNotification", new[] { "IsDeleted" });
            DropTable("dbo.MstInventyoryNotification",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InventyoryNotification_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
