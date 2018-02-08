namespace projeto_agency.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        autorID = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        senha = c.String(nullable: false, maxLength: 12, unicode: false),
                        email = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.autorID);
            
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        livroID = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        descricao = c.String(nullable: false, maxLength: 255, unicode: false),
                        autorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.livroID)
                .ForeignKey("dbo.Autor", t => t.autorID, cascadeDelete: true)
                .Index(t => t.autorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livro", "autorID", "dbo.Autor");
            DropIndex("dbo.Livro", new[] { "autorID" });
            DropTable("dbo.Livro");
            DropTable("dbo.Autor");
        }
    }
}
