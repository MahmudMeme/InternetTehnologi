namespace rabotenjeSoBaza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMoviesAndClientRealeshensip : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieClints",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Clint_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Clint_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clints", t => t.Clint_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Clint_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieClints", "Clint_Id", "dbo.Clints");
            DropForeignKey("dbo.MovieClints", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieClints", new[] { "Clint_Id" });
            DropIndex("dbo.MovieClints", new[] { "Movie_Id" });
            DropTable("dbo.MovieClints");
        }
    }
}
