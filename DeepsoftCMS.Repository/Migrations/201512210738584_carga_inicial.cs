namespace ZafiroCMS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carga_inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administradors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PerfilId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Email = c.String(),
                        Activo = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        CuentaId = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Perfils", t => t.PerfilId, cascadeDelete: true)
                .Index(t => t.PerfilId);
            
            CreateTable(
                "dbo.Articulos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticuloPadreId = c.Int(nullable: false),
                        EsquemaId = c.Int(nullable: false),
                        AutorId = c.Int(nullable: false),
                        Titulo = c.String(),
                        Subtitulo = c.String(),
                        Resumen = c.String(),
                        Descripcion = c.String(),
                        Descripcion2 = c.String(),
                        Destacado = c.Boolean(nullable: false),
                        FechaPublicacion = c.DateTime(nullable: false),
                        RutaEstatica = c.String(),
                        Posicion = c.Int(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articulos", t => t.ArticuloPadreId)
                .ForeignKey("dbo.Administradors", t => t.AutorId, cascadeDelete: true)
                .ForeignKey("dbo.Esquemas", t => t.EsquemaId, cascadeDelete: true)
                .Index(t => t.ArticuloPadreId)
                .Index(t => t.EsquemaId)
                .Index(t => t.AutorId);
            
            CreateTable(
                "dbo.Esquemas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlantillaId = c.Int(nullable: false),
                        EsquemaPadreId = c.Int(nullable: false),
                        SeccionId = c.Int(nullable: false),
                        Iteraciones = c.Int(nullable: false),
                        Posicion = c.Short(nullable: false),
                        EsPágina = c.Boolean(nullable: false),
                        Alias = c.String(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Esquemas", t => t.EsquemaPadreId)
                .ForeignKey("dbo.Plantillas", t => t.PlantillaId, cascadeDelete: true)
                .ForeignKey("dbo.Secciones", t => t.SeccionId, cascadeDelete: true)
                .Index(t => t.PlantillaId)
                .Index(t => t.EsquemaPadreId)
                .Index(t => t.SeccionId);
            
            CreateTable(
                "dbo.Plantillas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        AdminView = c.String(),
                        FrontView = c.String(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Secciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Perfils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AutorId = c.Int(nullable: false),
                        Titulo = c.String(),
                        Resumen = c.String(),
                        Descripcion = c.String(),
                        FechaPublicacion = c.DateTime(nullable: false),
                        Publicado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Administradors", t => t.AutorId, cascadeDelete: true)
                .Index(t => t.AutorId);
            
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        Mensaje = c.String(),
                        FechaRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.PostId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Email = c.String(),
                        Activo = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        CuentaId = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            //RenameTable("dbo.Perfils", "dbo.Perfiles");
            //RenameTable("dbo.Administradors", "dbo.Administradors");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comentarios", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Comentarios", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "AutorId", "dbo.Administradors");
            DropForeignKey("dbo.Administradors", "PerfilId", "dbo.Perfils");
            DropForeignKey("dbo.Articulos", "EsquemaId", "dbo.Esquemas");
            DropForeignKey("dbo.Esquemas", "SeccionId", "dbo.Secciones");
            DropForeignKey("dbo.Secciones", "SeccionPadreId", "dbo.Secciones");
            DropForeignKey("dbo.Esquemas", "PlantillaId", "dbo.Plantillas");
            DropForeignKey("dbo.Esquemas", "EsquemaPadreId", "dbo.Esquemas");
            DropForeignKey("dbo.Articulos", "AutorId", "dbo.Administradors");
            DropForeignKey("dbo.Articulos", "ArticuloPadreId", "dbo.Articulos");
            DropIndex("dbo.Comentarios", new[] { "UsuarioId" });
            DropIndex("dbo.Comentarios", new[] { "PostId" });
            DropIndex("dbo.Posts", new[] { "AutorId" });
            DropIndex("dbo.Secciones", new[] { "SeccionPadreId" });
            DropIndex("dbo.Esquemas", new[] { "SeccionId" });
            DropIndex("dbo.Esquemas", new[] { "EsquemaPadreId" });
            DropIndex("dbo.Esquemas", new[] { "PlantillaId" });
            DropIndex("dbo.Articulos", new[] { "AutorId" });
            DropIndex("dbo.Articulos", new[] { "EsquemaId" });
            DropIndex("dbo.Articulos", new[] { "ArticuloPadreId" });
            DropIndex("dbo.Administradors", new[] { "PerfilId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Comentarios");
            DropTable("dbo.Posts");
            DropTable("dbo.Perfils");
            DropTable("dbo.Secciones");
            DropTable("dbo.Plantillas");
            DropTable("dbo.Esquemas");
            DropTable("dbo.Articulos");
            DropTable("dbo.Administradors");
        }
    }
}
