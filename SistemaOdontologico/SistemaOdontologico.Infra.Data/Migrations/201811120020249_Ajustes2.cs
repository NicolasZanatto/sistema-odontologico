namespace SistemaOdontologico.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajustes2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinicas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50, storeType: "nvarchar"),
                        IdUsuario = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        Senha = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        Nome = c.String(unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        TipoUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Pacientes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Idade = c.Int(nullable: false),
                        Telefone = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Observacao = c.String(unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Clinicas", "IdUsuario", "dbo.Usuarios");
            DropIndex("dbo.Clinicas", new[] { "IdUsuario" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Clinicas");
        }
    }
}
