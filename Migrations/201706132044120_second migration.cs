namespace Motivation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tasks", newName: "Issues");
            AddColumn("dbo.Actions", "IssueId", c => c.Int());
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.Users", "Login", c => c.String());
            DropColumn("dbo.Actions", "TaskId");
            DropColumn("dbo.Users", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserName", c => c.String());
            AddColumn("dbo.Actions", "TaskId", c => c.Int());
            DropColumn("dbo.Users", "Login");
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Actions", "IssueId");
            RenameTable(name: "dbo.Issues", newName: "Tasks");
        }
    }
}
