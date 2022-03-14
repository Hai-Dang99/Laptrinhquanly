namespace LHDBaiThucHanh214.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HaiDangs",
                c => new
                    {
                        HaiDangID = c.String(nullable: false, maxLength: 128),
                        HaiDangName = c.String(),
                    })
                .PrimaryKey(t => t.HaiDangID);
            
            DropTable("dbo.Student");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 50),
                        StudentName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.StudentID);
            
            DropTable("dbo.HaiDangs");
        }
    }
}
