using AplicativoWeb.Models;//camada model 
using Microsoft.AspNetCore.Mvc; //microsoft
namespace AplicativoWeb.Controllers; // Definindo

// criamos a classe Controller 
public class CursoController:Controller{
public IActionResult Index() {
    Curso c1 = new Curso ();
    //set
    c1.Descricao = "Primeiros Passos no ASP.NET";
    c1.TituloInterno = "Desenvolvedor c#";
    c1.TituloMarketing = "Crie Aplicativos Incríveis";

    //get
    ViewData ["desc"] = c1.Descricao;
    ViewData["titInt"] = c1.TituloInterno;
    ViewData["titMark"] = c1.TituloMarketing;
return View();
5


}
}
