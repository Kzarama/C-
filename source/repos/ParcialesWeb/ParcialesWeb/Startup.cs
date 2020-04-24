using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ParcialesWeb.Data;
using ModelsK;

namespace ParcialKesWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            CargarDatos(app.ApplicationServices);
        }

        private void CargarDatos(IServiceProvider applicationServices)
        {
            using (var serviceScope = applicationServices.CreateScope())
            {
                var ctx = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                if (ctx.EstudianteK.Any())
                {
                    return;   // La base de datos ya tiene datos               
                }
                var estudiantes = new List<EstudianteK> {
            new EstudianteK { Nombre = "Hugo Chávez Frías", Email = "chavez@venezuela.com" },
            new EstudianteK { Nombre = "Alvaro Uribe Vélez" , Email = "uribe@colombia.com"},
            new EstudianteK { Nombre = "Juan Manuel Santos Calderón", Email = "santos@colombia.com" },
            new EstudianteK { Nombre = "Rafael Correa Delgado", Email = "correo@ecuador.com" },
            new EstudianteK { Nombre = "Juan Evo Morales Ayma", Email = "Evo@bolivia.com" },
            new EstudianteK { Nombre = "Nicolás Maduro Moros", Email = "Maduro@venezuela.com" },
            new EstudianteK { Nombre = "Ollanta Humala Tasso", Email = "Ollanta@peru.com" },
            new EstudianteK { Nombre = "Ricardo Martinelli", Email = "Martinelli@panama.com" },
            new EstudianteK { Nombre = "José Alberto Mujica Cordano", Email = "Mujica@uruguay.com" },
            new EstudianteK { Nombre = "Luis Federico Franco Gómez", Email = "Franco@paraguay.com" },
            new EstudianteK { Nombre = "Miguel Sebastián Piñera", Email = "Piñera@chile.com" },
            new EstudianteK { Nombre = "Luis Ignacio Lula Da Silva", Email = "Lula@brasil.com" },
            new EstudianteK { Nombre = "Dilma Vana Roussett", Email = "Roussett@brasil.com" },
            new EstudianteK { Nombre = "Cristina Fernández de Kirchner", Email = "Kirchner@argentina.com" },
            new EstudianteK { Nombre = "Pedro Pablo Kuczynski", Email = "Kuczynski@peru.com" }
        };
                estudiantes.ForEach(e => ctx.EstudianteK.Add(e));
                ctx.SaveChanges();

                var materias = new List<MateriaK> {
            new MateriaK { Nombre = "Contabilidad y Costos", Creditos = 3 },
            new MateriaK { Nombre = "Electricidad y Magnetismo", Creditos = 4 },
            new MateriaK { Nombre = "Algorítmos y Estructuras de Datos", Creditos = 3 },
            new MateriaK { Nombre = "Ingeniería de Procesos", Creditos = 2 },
            new MateriaK { Nombre = "Electiva en CTS", Creditos = 5 },
            new MateriaK { Nombre = "Fundamentos de Mercadeo", Creditos = 2 },
            new MateriaK { Nombre = "Ingeniería Económica", Creditos = 3 },
            new MateriaK { Nombre = "Matemática Discreta", Creditos = 4 },
            new MateriaK { Nombre = "Modelado", Creditos = 2 },
            new MateriaK { Nombre = "Integrador I", Creditos = 3 }
        };
                materias.ForEach(m => ctx.MateriaK.Add(m));
                ctx.SaveChanges();

                var cursos = new List<CursoK> {
            new CursoK { AñoSem =161, Grupo = 1, Profesor = "Donald John trump", MateriaKId = 1 },
            new CursoK { AñoSem =162, Grupo = 1, Profesor = "Barack Hussein Obama", MateriaKId = 2 },
            new CursoK { AñoSem =162, Grupo = 1, Profesor = "Hillary Diane Rodham Clinton", MateriaKId = 3 },
            new CursoK { AñoSem =161, Grupo = 1, Profesor = "Mariano Rajoy Brey", MateriaKId = 4 },
            new CursoK { AñoSem =161, Grupo = 1, Profesor = "Verónica Michelle Bachelet Jeria", MateriaKId = 5 },
        };
                cursos.ForEach(c => ctx.CursoK.Add(c));
                ctx.SaveChanges();

                var parciales = new List<ParcialK> {
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 03, 25), Nota = 1.0, EstudianteKId = 1, CursoKId = 1, Porcentaje = 25 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 03, 25), Nota = 3.5, EstudianteKId = 2, CursoKId = 1, Porcentaje = 20 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 03, 25), Nota = 4.2, EstudianteKId = 3, CursoKId = 1, Porcentaje = 15 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 08, 18), Nota = 5.0, EstudianteKId = 4, CursoKId = 2, Porcentaje = 10 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 08, 18), Nota = 2.7, EstudianteKId = 5, CursoKId = 2, Porcentaje = 25 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 08, 18), Nota = 3.7, EstudianteKId = 6, CursoKId = 2, Porcentaje = 20 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 03, 26), Nota = 3.8, EstudianteKId = 7, CursoKId = 3, Porcentaje = 30 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 03, 26), Nota = 1.9, EstudianteKId = 8, CursoKId = 3, Porcentaje = 25 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 03, 26), Nota = 1.3, EstudianteKId = 9, CursoKId = 3, Porcentaje = 20 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 04, 01), Nota = 2.5, EstudianteKId = 10, CursoKId = 4, Porcentaje = 15 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 04, 01), Nota = 3.9, EstudianteKId = 11, CursoKId = 4, Porcentaje = 35 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 04, 01), Nota = 4.3, EstudianteKId = 12, CursoKId = 4, Porcentaje = 15 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 02, 28), Nota = 5.0, EstudianteKId = 13, CursoKId = 5, Porcentaje = 10 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 02, 28), Nota = 2.6, EstudianteKId = 14, CursoKId = 5, Porcentaje = 20 },
            new ParcialK { Número = 1, Fecha = new DateTime(2016, 02, 28), Nota = 4.7, EstudianteKId = 15, CursoKId = 5, Porcentaje = 25 },
        };
                parciales.ForEach(p => ctx.ParcialK.Add(p));
                ctx.SaveChanges();
            }
        }


    }

}
