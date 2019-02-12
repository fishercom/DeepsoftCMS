namespace DeepsoftCMS.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DeepsoftCMS.Repository.DDDContext;
    using DeepsoftCMS.Repository.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCMSRepository>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFCMSRepository context)
        {
            //  This method will be called after migrating to the latest version.
            #region AdmProfile
            var sa = new AdmProfile()
            {
                Name = "Administrador"
            };
            var Author = new AdmProfile()
            {
                Name = "Author"
            };
            #endregion

            #region WebUser
            var adminuser = new AdmUser()
            {
                Name = "Fischer",
                LastName = "Tirado",
                Email = "fishdev@gmail.com",
                Active = true,
                AdmProfile = sa
            };
            var Author1 = new AdmUser()
            {
                Name = "Luchito",
                LastName = "Perez",
                Email = "lperez@micorreo.com",
                Active = true,
                AdmProfile = Author
            };
            var Author2 = new AdmUser()
            {
                Name = "Marita",
                LastName = "Rojas",
                Email = "mrojar@micorreo.com",
                Active = true,
                AdmProfile = Author
            };
            var WebUser1 = new WebUser()
            {
                Name = "Rebecca",
                LastName = "Huertas",
                Email = "rebecca88@micorreo.com",
                RegisterDate = new DateTime(2010, 5, 13),
                Active = true
            };
            var WebUser2 = new WebUser()
            {
                Name = "Gianina",
                LastName = "Mejía",
                Email = "gianimj@micorreo.com",
                RegisterDate = new DateTime(2012, 8, 22),
                Active = true
            };
            #endregion

            #region AdmMenu
            var menu01 = new AdmMenu()
            {
                Name = "Dashboard",
                Icon = "dashboard",
                Position = 1,
                Active = true
            };
            var menu02 = new AdmMenu()
            {
                Name = "Posts",
                Icon = "tags",
                Position = 2,
                Active = true
            };
            var menu03 = new AdmMenu()
            {
                Name = "Páginas",
                Icon = "globe",
                Position = 3,
                Active = true
            };
            var menu04 = new AdmMenu()
            {
                Name = "Configuración",
                Icon = "edit",
                Position = 4,
                Active = true
            };
            var menu0401 = new AdmMenu()
            {
                Name = "Administradores",
                Position = 1,
                Active = true,

                MenuParent = menu04
            };
            var menu0402 = new AdmMenu()
            {
                Name = "Usuarios Web",
                Position = 2,
                Active = true,

                MenuParent = menu04
            };
            var menu0403 = new AdmMenu()
            {
                Name = "Perfiles",
                Position = 3,
                Active = true,

                MenuParent = menu04
            };
            var menu0404 = new AdmMenu()
            {
                Name = "Esquemas del CMS",
                Position = 4,
                Active = true,

                MenuParent = menu04
            };
            var menu0405 = new AdmMenu()
            {
                Name = "Plantillas del CMS",
                Position = 5,
                Active = true,

                MenuParent = menu04
            };
            #endregion

            #region AdmModule
            #endregion

            #region Section
            //var Section_Home = new Section()
            //{
            //    Name = "Home Page",
            //    TagName = "home",
            //    Internal = false,
            //    Active = true
            //};
            //var Section_Footer = new Section()
            //{
            //    Name = "Pie de Página",
            //    TagName = "footer",
            //    Internal = false,
            //    Active = true
            //};
            //var Section_Toolbar = new Section()
            //{
            //    Name = "Herramientas",
            //    TagName = "toolbar",
            //    Internal = false,
            //    Active = true
            //};
            //var Section_Services = new Section()
            //{
            //    Name = "Servicios",
            //    TagName = "services",
            //    Internal = true,
            //    Active = true
            //};
            //var Section_Portfolio= new Section()
            //{
            //    Name = "Portafolio",
            //    TagName = "portfolio",
            //    Internal = true,
            //    Active = true
            //};
            //var Section_About = new Section()
            //{
            //    Name = "Acerca de",
            //    TagName = "about",
            //    Internal = true,
            //    Active = true
            //};
            //var Section_Team = new Section()
            //{
            //    Name = "Equipo",
            //    TagName = "team",
            //    Internal = true,
            //    Active = true
            //};
            //var Section_Contact = new Section()
            //{
            //    Name = "Contacto",
            //    TagName = "contact",
            //    Internal = true,
            //    Active = true
            //};
            //var Section_Blog = new Section()
            //{
            //    Name = "Blog",
            //    TagName = "blog",
            //    Internal = true,
            //    Active = true
            //};
            #endregion

            #region Schema
            var Schema_Home = new CmsSchema()
            {
                Name = "Sección Home",
                Iterations = 1,
                Position = 1,
                IsPage = false,
                Active = true,
            };
            var Schema_Services = new CmsSchema()
            {
                Name = "Sección Servicios",
                Iterations = 1,
                Position = 2,
                IsPage = true,
                Active = true,
            };
            var Schema_Portfolio = new CmsSchema()
            {
                Name = "Sección Portafolio",
                Iterations = 1,
                Position = 3,
                IsPage = true,
                Active = true,
            };
            var Schema_About = new CmsSchema()
            {
                Name = "Sección Acerca de",
                Iterations = 1,
                Position = 4,
                IsPage = true,
                Active = true,
            };
            var Schema_Team = new CmsSchema()
            {
                Name = "Sección El Equipo",
                Iterations = 1,
                Position = 5,
                IsPage = true,
                Active = true,
            };
            var Schema_Contact = new CmsSchema()
            {
                Name = "Sección Contáctenos",
                Iterations = 1,
                Position = 6,
                IsPage = true,
                Active = true,
            };
            var Schema_Blog = new CmsSchema()
            {
                Name = "Sección Blog",
                Iterations = 1,
                Position = 7,
                IsPage = true,
                Active = true,
            };
            var Schema_Home1 = new CmsSchema()
            {
                SchemaParent = Schema_Home,
                Name = "Animación Home",
                Iterations=1,
                Position=1,
                IsPage = false,
                Active = true,
            };
            var Schema_Home11 = new CmsSchema()
            {
                SchemaParent = Schema_Home1,
                Name = "Animación Intro",
                Iterations = 1,
                Position = 1,
                IsPage = false,
                Active = true,
            };
            var Schema_Services1 = new CmsSchema()
            {
                SchemaParent = Schema_Services,
                Name = "Servicio",
                Position = 1,
                IsPage = true,
                Active = true,
            };
            var Schema_Portfolio1 = new CmsSchema()
            {
                SchemaParent = Schema_Portfolio,
                Name = "Portafolio",
                Position = 1,
                IsPage = true,
                Active = true,
            };
            var Schema_About1 = new CmsSchema()
            {
                SchemaParent = Schema_About,
                Name = "Historia",
                Position = 1,
                IsPage = true,
                Active = true,
            };
            var Schema_Team1 = new CmsSchema()
            {
                SchemaParent = Schema_Team,
                Name = "Bloque Nuestro Equipo",
                Iterations = 1,
                Position = 1,
                IsPage = true,
                Active = true,
            };
            var Schema_Team2 = new CmsSchema()
            {
                SchemaParent = Schema_Team,
                Name = "Bloque Nuestros Clientes",
                Iterations = 1,
                Position = 1,
                IsPage = true,
                Active = true,
            };
            var Schema_Team11 = new CmsSchema()
            {
                SchemaParent = Schema_Team1,
                Name = "Equipo",
                Position = 1,
                IsPage = false,
                Active = true,
            };
            var Schema_Team21 = new CmsSchema()
            {
                SchemaParent = Schema_Team2,
                Name = "Cliente",
                Position = 1,
                IsPage = false,
                Active = true,
            };
            var Schema_Contact1 = new CmsSchema()
            {
                SchemaParent = Schema_Contact,
                Name = "Formulario Contacto",
                Iterations = 1,
                Position = 1,
                IsPage = true,
                Active = true,
            };
            #endregion

            #region Article
            var Article_Home = new CmsArticle()
            {
                Schema = Schema_Home,
                Title = "Inicio",
                XmlParams = "<root><item key=\"hashtag\" value=\"#home\" /></root>",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Services = new CmsArticle()
            {
                Schema = Schema_Services,
                Title = "Servicios",
                SubTitle = "Lorem ipsum dolor sit amet consectetur.",
                XmlParams = "<root><item key=\"hashtag\" value=\"#services\" /></root>",
                Author = adminuser,
                Position = 2,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Portfolio = new CmsArticle()
            {
                Schema = Schema_Portfolio,
                Title = "Portafolio",
                SubTitle = "Lorem ipsum dolor sit amet consectetur.",
                XmlParams = "<root><item key=\"hashtag\" value=\"#portfolio\" /></root>",
                Author = adminuser,
                Position = 3,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_About = new CmsArticle()
            {
                Schema = Schema_About,
                Title = "Acerca de",
                SubTitle = "Lorem ipsum dolor sit amet consectetur.",
                XmlParams = "<root><item key=\"hashtag\" value=\"#about\" /></root>",
                Author = adminuser,
                Position = 4,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team = new CmsArticle()
            {
                Schema = Schema_Team,
                Title = "El Equipo",
                SubTitle = "Lorem ipsum dolor sit amet consectetur.",
                XmlParams = "<root><item key=\"hashtag\" value=\"#team\" /></root>",
                Author = adminuser,
                Position = 5,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Contact = new CmsArticle()
            {
                Schema = Schema_Contact,
                Title = "Contáctenos",
                SubTitle = "Lorem ipsum dolor sit amet consectetur.",
                XmlParams = "<root><item key=\"hashtag\" value=\"#contact\" /></root>",
                Author = adminuser,
                Position = 6,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Home01 = new CmsArticle()
            {
                Schema = Schema_Home1,
                ArticleParent = Article_Home,
                Title = "Animación Home",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Home0101 = new CmsArticle()
            {
                Schema = Schema_Home11,
                ArticleParent = Article_Home01,
                Title = "Bienvenido a Nuestro Estudio!",
                SubTitle = "Es bueno conocerte",
                XmlParams = "<root><item key=\"url\" value=\"#services\" /><item key=\"tag\" value=\"Dime Más\" /></root>",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Services01 = new CmsArticle()
            {
                Schema = Schema_Services1,
                ArticleParent = Article_Services,
                Title = "E-Commerce",
                XmlParams = "<root><item key=\"css\" value=\"fa-shopping-cart\" /></root>",
                Resumen = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima maxime quam architecto quo inventore harum ex magni, dicta impedit.",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Services02 = new CmsArticle()
            {
                Schema = Schema_Services1,
                ArticleParent = Article_Services,
                Title = "Responsive Design",
                XmlParams = "<root><item key=\"css\" value=\"fa-laptop\" /></root>",
                Resumen = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima maxime quam architecto quo inventore harum ex magni, dicta impedit.",
                Author = adminuser,
                Position = 2,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Services03 = new CmsArticle()
            {
                Schema = Schema_Services1,
                ArticleParent = Article_Services,
                Title = "Web Security",
                XmlParams = "<root><item key=\"css\" value=\"fa-lock\" /></root>",
                Resumen = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima maxime quam architecto quo inventore harum ex magni, dicta impedit.",
                Author = adminuser,
                Position = 3,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Portfolio01 = new CmsArticle()
            {
                Schema = Schema_Portfolio1,
                ArticleParent = Article_Portfolio,
                Title = "Round Icons",
                XmlParams = "<root><item key=\"image\" value=\"/img/portfolio/roundicons.png\" /></root>",
                SubTitle = "Graphic Design",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Portfolio02 = new CmsArticle()
            {
                Schema = Schema_Portfolio1,
                ArticleParent = Article_Portfolio,
                Title = "Startup Framework",
                XmlParams = "<root><item key=\"image\" value=\"/img/portfolio/startup-framework.png\" /></root>",
                SubTitle = "Website Design",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Portfolio03 = new CmsArticle()
            {
                Schema = Schema_Portfolio1,
                ArticleParent = Article_Portfolio,
                Title = "Treehouse",
                XmlParams = "<root><item key=\"image\" value=\"/img/portfolio/treehouse.png\" /></root>",
                SubTitle = "Website Design",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Portfolio04 = new CmsArticle()
            {
                Schema = Schema_Portfolio1,
                ArticleParent = Article_Portfolio,
                Title = "Golden",
                XmlParams = "<root><item key=\"image\" value=\"/img/portfolio/golden.png\" /></root>",
                SubTitle = "Website Design",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Portfolio05 = new CmsArticle()
            {
                Schema = Schema_Portfolio1,
                ArticleParent = Article_Portfolio,
                Title = "Escape",
                XmlParams = "<root><item key=\"image\" value=\"/img/portfolio/escape.png\" /></root>",
                SubTitle = "Website Design",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Portfolio06 = new CmsArticle()
            {
                Schema = Schema_Portfolio1,
                ArticleParent = Article_Portfolio,
                Title = "Dreams",
                XmlParams = "<root><item key=\"image\" value=\"/img/portfolio/dreams.png\" /></root>",
                SubTitle = "Website Design",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_About01 = new CmsArticle()
            {
                Schema = Schema_About1,
                ArticleParent = Article_About,
                Title = "Our Humble Beginnings",
                SubTitle = "2009-2011",
                XmlParams = "<root><item key=\"image\" value=\"/img/about/1.jpg\" /></root>",
                Resumen = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt ut voluptatum eius sapiente, totam reiciendis temporibus qui quibusdam, recusandae sit vero unde, sed, incidunt et ea quo dolore laudantium consectetur!",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_About02 = new CmsArticle()
            {
                Schema = Schema_About1,
                ArticleParent = Article_About,
                Title = "An Agency is Born",
                SubTitle = "March 2011",
                XmlParams = "<root><item key=\"image\" value=\"/img/about/2.jpg\" /><item key=\"align\" value=\"right\" /></root>",
                Resumen = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt ut voluptatum eius sapiente, totam reiciendis temporibus qui quibusdam, recusandae sit vero unde, sed, incidunt et ea quo dolore laudantium consectetur!",
                Author = adminuser,
                Position = 2,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_About03 = new CmsArticle()
            {
                Schema = Schema_About1,
                ArticleParent = Article_About,
                Title = "Transition to Full Service",
                SubTitle = "December 2012",
                XmlParams = "<root><item key=\"image\" value=\"/img/about/3.jpg\" /></root>",
                Resumen = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt ut voluptatum eius sapiente, totam reiciendis temporibus qui quibusdam, recusandae sit vero unde, sed, incidunt et ea quo dolore laudantium consectetur!",
                Author = adminuser,
                Position = 3,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_About04 = new CmsArticle()
            {
                Schema = Schema_About1,
                ArticleParent = Article_About,
                Title = "Phase Two Expansion",
                SubTitle = "July 2014",
                XmlParams = "<root><item key=\"image\" value=\"/img/about/4.jpg\" /><item key=\"align\" value=\"right\" /></root>",
                Resumen = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt ut voluptatum eius sapiente, totam reiciendis temporibus qui quibusdam, recusandae sit vero unde, sed, incidunt et ea quo dolore laudantium consectetur!",
                Author = adminuser,
                Position = 4,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team01 = new CmsArticle()
            {
                Schema = Schema_Team1,
                ArticleParent = Article_Team,
                Title = "Nuestro Equipo",
                Resumen = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aut eaque, laboriosam veritatis, quos non quis ad perspiciatis, totam corporis ea, alias ut unde.",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team02 = new CmsArticle()
            {
                Schema = Schema_Team2,
                ArticleParent = Article_Team,
                Title = "Nuestros Clientes",
                Author = adminuser,
                Position = 2,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team0101 = new CmsArticle()
            {
                Schema = Schema_Team11,
                ArticleParent = Article_Team01,
                Title = "Kay Garland",
                SubTitle = "Lead Designer",
                XmlParams = "<root><item key=\"image\" value=\"/img/team/1.jpg\" /><item key=\"twitter\" value=\"#\" /><item key=\"facebook\" value=\"#\" /><item key=\"linkedin\" value=\"#\" /></root>",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team0102 = new CmsArticle()
            {
                Schema = Schema_Team11,
                ArticleParent = Article_Team01,
                Title = "Larry Parker",
                SubTitle = "Lead Marketer",
                XmlParams = "<root><item key=\"image\" value=\"/img/team/2.jpg\" /><item key=\"twitter\" value=\"#\" /><item key=\"facebook\" value=\"#\" /><item key=\"linkedin\" value=\"#\" /></root>",
                Author = adminuser,
                Position = 2,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team0103 = new CmsArticle()
            {
                Schema = Schema_Team11,
                ArticleParent = Article_Team01,
                Title = "Diana Pertersen",
                SubTitle = "Lead Developer",
                XmlParams = "<root><item key=\"image\" value=\"/img/team/3.jpg\" /><item key=\"twitter\" value=\"#\" /><item key=\"facebook\" value=\"#\" /><item key=\"linkedin\" value=\"#\" /></root>",
                Author = adminuser,
                Position = 3,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team0201 = new CmsArticle()
            {
                Schema = Schema_Team21,
                ArticleParent = Article_Team02,
                Title = "evanto",
                XmlParams = "<root><item key=\"image\" value=\"/img/logos/envato.jpg\" /></root>",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team0202 = new CmsArticle()
            {
                Schema = Schema_Team21,
                ArticleParent = Article_Team02,
                Title = "designmodo",
                XmlParams = "<root><item key=\"image\" value=\"/img/logos/designmodo.jpg\" /></root>",
                Author = adminuser,
                Position = 2,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team0203 = new CmsArticle()
            {
                Schema = Schema_Team21,
                ArticleParent = Article_Team02,
                Title = "themeforest",
                XmlParams = "<root><item key=\"image\" value=\"/img/logos/themeforest.jpg\" /></root>",
                Author = adminuser,
                Position = 3,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Team0204 = new CmsArticle()
            {
                Schema = Schema_Team21,
                ArticleParent = Article_Team02,
                Title = "creative-market",
                XmlParams = "<root><item key=\"image\" value=\"/img/logos/creative-market.jpg\" /></root>",
                Author = adminuser,
                Position = 4,
                Active = true,
                RegisterDate = DateTime.Now
            };
            var Article_Contact01 = new CmsArticle()
            {
                Schema = Schema_Contact1,
                ArticleParent = Article_Contact,
                Title = "Formulario de Contacto",
                Author = adminuser,
                Position = 1,
                Active = true,
                RegisterDate = DateTime.Now
            };

            #endregion

            #region Post
            var post1 = new Post()
            {
                Title = "El primer teléfono para gatos es una realidad",
                Resumen = "El primer teléfono para gatos ha llegado, y no es una mala broma. Weenect es una empresa que fabrica...",
                Description = "El primer teléfono para gatos ha llegado, y no es una mala broma. Weenect es una empresa que fabrica localizadores GPS para niños y perros, los cuales te permiten rastrearlos desde la comodidad de tu teléfono. Ahora toca el turno de los gatos con un nuevo localizador que además cuenta con teléfono integrado. El Weenect Cats se coloca en el collar de tu gato y tiene diversas funciones. Cuando tu mascota se sale de una zona determinada, tu teléfono envía una alerta y te permite llamarle gracias a que cuenta con una tarjeta SIM, así como un micrófono y parlantes que se ubican en el dispositivo.",
                Active = true,
                PublishDate = new DateTime(2015, 10, 15),
                RegisterDate = DateTime.Now,
                Author = Author1
            };
            var post2 = new Post()
            {
                Title = "10 funciones secretas de Google Drive",
                Resumen = "Las aplicaciones de Google Drive destacan por su simpleza y facilidad de uso. Si bien no están a la par de...",
                Description = "Las aplicaciones de Google Drive destacan por su simpleza y facilidad de uso. Si bien no están a la par de la suite Microsoft Office, Docs tiene cosas que son impresionantes, aunque no siempre están al alcance de la vista. <h2>Herramienta de búsqueda</h2> Google Docs nos da una mano con investigaciones permitiéndonos realizar búsquedas y luego citas de forma simple. Para esto, solo debemos ir a Herramientas y seleccionar Investigar seguidamente un cuadro de búsqueda se abrirá a la derecha y podremos buscar sobre cualquier temática. Si se desea podemos añadir un enlace o bien una cita al contenido. Otro aspecto interesante de la herramienta, es que permite realizar búsquedas sin tener que salir de la página en la cual estamos trabajando. <h2>Reconocimiento de voz</h2> Haciendo uso de un micrófono podemos utilizar la herramienta de reconocimiento de voz que funciona de maravillas. Nuevamente debemos dirigirnos a la sección de herramientas y seleccionar \"Escritura por voz\".",
                Active = true,
                PublishDate = new DateTime(2015, 10, 16),
                RegisterDate = DateTime.Now,
                Author = Author2
            };
            post1.AddComment(new Comment() { Message = "Me parece una excelente idea, creo que podría salvar muchas vidas.", WebUser = WebUser1, RegisterDate = DateTime.Now });
            post1.AddComment(new Comment() { Message = "No lo sé, creo que hay cosas mas importantes de las que deberían preocuparse.", WebUser = WebUser2, RegisterDate = DateTime.Now });
            post2.AddComment(new Comment() { Message = "Me encanto mucho el post, no sabía que podía personalizar mis carpetas.", WebUser = WebUser2, RegisterDate = DateTime.Now });
            #endregion

            context.AdmProfileRepository.Add(sa);
            context.AdmProfileRepository.Add(Author);

            context.AdmUserRepository.Add(adminuser);
            context.AdmUserRepository.Add(Author1);
            context.AdmUserRepository.Add(Author2);

            context.WebUserRepository.Add(WebUser1);
            context.WebUserRepository.Add(WebUser2);

            context.AdmMenuRepository.Add(menu01);
            context.AdmMenuRepository.Add(menu02);
            context.AdmMenuRepository.Add(menu03);
            context.AdmMenuRepository.Add(menu04);
            context.AdmMenuRepository.Add(menu0401);
            context.AdmMenuRepository.Add(menu0402);
            context.AdmMenuRepository.Add(menu0403);
            context.AdmMenuRepository.Add(menu0404);
            context.AdmMenuRepository.Add(menu0405);

            context.SchemaRepository.Add(Schema_Home);
            context.SchemaRepository.Add(Schema_Services);
            context.SchemaRepository.Add(Schema_Portfolio);
            context.SchemaRepository.Add(Schema_About);
            context.SchemaRepository.Add(Schema_Team);
            context.SchemaRepository.Add(Schema_Contact);
            context.SchemaRepository.Add(Schema_Blog);
            context.SchemaRepository.Add(Schema_Home1);
            context.SchemaRepository.Add(Schema_Home11);
            context.SchemaRepository.Add(Schema_Services1);
            context.SchemaRepository.Add(Schema_Portfolio1);
            context.SchemaRepository.Add(Schema_About1);
            context.SchemaRepository.Add(Schema_Team1);
            context.SchemaRepository.Add(Schema_Team2);
            context.SchemaRepository.Add(Schema_Contact1);

            context.ArticleRepository.Add(Article_Home);
            context.ArticleRepository.Add(Article_Services);
            context.ArticleRepository.Add(Article_Portfolio);
            context.ArticleRepository.Add(Article_About);
            context.ArticleRepository.Add(Article_Team);
            context.ArticleRepository.Add(Article_Contact);
            context.ArticleRepository.Add(Article_Home01);
            context.ArticleRepository.Add(Article_Home0101);
            context.ArticleRepository.Add(Article_Services01);
            context.ArticleRepository.Add(Article_Services02);
            context.ArticleRepository.Add(Article_Services03);
            context.ArticleRepository.Add(Article_Portfolio01);
            context.ArticleRepository.Add(Article_Portfolio02);
            context.ArticleRepository.Add(Article_Portfolio03);
            context.ArticleRepository.Add(Article_Portfolio04);
            context.ArticleRepository.Add(Article_Portfolio05);
            context.ArticleRepository.Add(Article_Portfolio06);
            context.ArticleRepository.Add(Article_About01);
            context.ArticleRepository.Add(Article_About02);
            context.ArticleRepository.Add(Article_About03);
            context.ArticleRepository.Add(Article_About04);
            context.ArticleRepository.Add(Article_Team01);
            context.ArticleRepository.Add(Article_Team02);
            context.ArticleRepository.Add(Article_Team0101);
            context.ArticleRepository.Add(Article_Team0102);
            context.ArticleRepository.Add(Article_Team0103);
            context.ArticleRepository.Add(Article_Team0201);
            context.ArticleRepository.Add(Article_Team0202);
            context.ArticleRepository.Add(Article_Team0203);
            context.ArticleRepository.Add(Article_Team0204);
            context.ArticleRepository.Add(Article_Contact01);

            context.PostRepository.Add(post1);
            context.PostRepository.Add(post2);

            context.Commit();


        }
    }
}