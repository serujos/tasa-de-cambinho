using Microsoft.AspNetCore.Mvc;
using prac1_lab_cjjosmer.Models;

namespace prac1_lab_cjjosmer.Controllers
{
    public class CambioController : Controller
    {
        // obtener
        public IActionResult Index()
        {
                return  View(new CambioViewModel());
        }

        // postear
        [HttpPost]
        public IActionResult Index(CambioViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                if (model.MonedaOrigen == model.MonedaDestino)
                {
                    model.Resultado = model.CantidadOrigen;
                    model.Mensaje = "Monedas Iguales";
                }
                else
                {
                
                    decimal cantidadEnPEN = 0m;

                    
                    switch (model.MonedaOrigen)
                    {
                        case "BRL":
                            cantidadEnPEN = model.CantidadOrigen * 0.634m;
                            break;
                        case "USD":
                            cantidadEnPEN = model.CantidadOrigen * 3.652m;
                            break;
                        case "PEN":
                            cantidadEnPEN = model.CantidadOrigen;
                            break;
                        default:
                            model.Mensaje = "Moneda origen desconocida.";
                            return View(model);
                    }

                    
                    switch (model.MonedaDestino)
                    {
                        case "BRL":
                            // reales a soles: 1/0.634
                            model.Resultado = cantidadEnPEN / 0.634m;
                            break;
                        case "USD":
                            // dolares a soles: 1/3.652
                            model.Resultado = cantidadEnPEN / 3.652m;
                            break;
                        case "PEN":
                            model.Resultado = cantidadEnPEN;
                            break;
                        default:
                            model.Mensaje = "Moneda destino desconocida.";
                            return View(model);
                    }

                    model.Mensaje = "Conversión realizada.";
                }
            }
            return View(model);
        }
    }
}
