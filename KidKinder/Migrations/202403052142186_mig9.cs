namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffBranches",
                c => new
                    {
                        StaffBranchId = c.Int(nullable: false, identity: true),
                        StaffBranchName = c.String(),
                    })
                .PrimaryKey(t => t.StaffBranchId);
            
            AddColumn("dbo.Staffs", "StaffBranch_StaffBranchId", c => c.Int());
            CreateIndex("dbo.Staffs", "StaffBranch_StaffBranchId");
            AddForeignKey("dbo.Staffs", "StaffBranch_StaffBranchId", "dbo.StaffBranches", "StaffBranchId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "StaffBranch_StaffBranchId", "dbo.StaffBranches");
            DropIndex("dbo.Staffs", new[] { "StaffBranch_StaffBranchId" });
            DropColumn("dbo.Staffs", "StaffBranch_StaffBranchId");
            DropTable("dbo.StaffBranches");
        }
    }
}
