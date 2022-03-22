namespace LHDBaiTapLon214.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            AddColumn("dbo.Diem", "MaSinhVien", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Diem", "MaSinhVien");
            DropTable("dbo.Accounts");
        }
    }
}
