namespace SistemaOdontologico.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pacientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        TipoSexo = c.Int(nullable: false),
                        Idade = c.Int(nullable: false),
                        Telefone = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Observacao = c.String(maxLength: 1000, storeType: "nvarchar"),
                        IdUsuario = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario)
                .Index(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "IdUsuario", "dbo.Usuarios");
            DropIndex("dbo.Pacientes", new[] { "IdUsuario" });
            DropTable("dbo.Pacientes");
        }
    }
}
