using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Zasylogic.Models;

namespace Zasylogic.Controllers
{
    public class TablaController : Controller
    {
        
        public ActionResult Index()
        {
            var listaClientes = new[]
{
    new Cliente { Nombre = "Natalia", Apellidos = "Meneses", Telefono="11111" ,Email = "natalia@gmail.com", Sexo="Mujer", Motivo=TiposMotivo.Incidencia, CreatedAt= DateTime.Parse("03/09/2021") },
    new Cliente { Nombre = "Carolina", Apellidos = "Ramirez", Telefono="11111" ,Email = "Carolina@gmail.com", Sexo="Mujer", Motivo=TiposMotivo.Reclamacion, CreatedAt= DateTime.Parse("05/09/2021") },
     new Cliente { Nombre = "Andres", Apellidos = "Corredor", Telefono="11111" ,Email = "Andres@gmail.com", Sexo="Hombre", Motivo=TiposMotivo.Reclamacion , CreatedAt= DateTime.Parse("03/09/2021")},
      new Cliente { Nombre = "Lorena", Apellidos = "Salazar", Telefono="11111" ,Email = "Lorena@gmail.com", Sexo="Mujer", Motivo=TiposMotivo.Queja , CreatedAt= DateTime.Parse("10/09/2021")},
       new Cliente { Nombre = "Eduardo", Apellidos = "Andrade", Telefono="11111" ,Email = "Eduardo@gmail.com", Sexo="Hombre", Motivo=TiposMotivo.Sugerencia , CreatedAt= DateTime.Parse("04/10/2021")},
};

            return View(listaClientes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}