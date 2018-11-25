namespace SistemaOdontologico.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Radiografias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Radiografias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdPaciente = c.Long(nullable: false),
                        IdClinica = c.Long(nullable: false),
                        Data = c.DateTime(nullable: false, precision: 0),
                        Hora = c.DateTime(nullable: false, precision: 0),
                        Observacao = c.String(maxLength: 1000, storeType: "nvarchar"),
                        LinkImg = c.String(maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicas", t => t.IdClinica)
                .ForeignKey("dbo.Pacientes", t => t.IdPaciente)
                .Index(t => t.IdPaciente)
                .Index(t => t.IdClinica);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Radiografias", "IdPaciente", "dbo.Pacientes");
            DropForeignKey("dbo.Radiografias", "IdClinica", "dbo.Clinicas");
            DropIndex("dbo.Radiografias", new[] { "IdClinica" });
            DropIndex("dbo.Radiografias", new[] { "IdPaciente" });
            DropTable("dbo.Radiografias");
        }
    }
}
