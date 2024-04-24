﻿namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MainTitle = c.String(),
                        DateInterval = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        TicketProperty1 = c.String(),
                        TicketProperty2 = c.String(),
                        TicketProperty3 = c.String(),
                        TicketProperty4 = c.String(),
                        TicketProperty5 = c.String(),
                        TicketProperty6 = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TicketID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
            DropTable("dbo.Features");
            DropTable("dbo.Artists");
        }
    }
}
