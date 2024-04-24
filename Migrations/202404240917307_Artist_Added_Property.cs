﻿namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Artist_Added_Property : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "Description2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "Description2");
        }
    }
}
