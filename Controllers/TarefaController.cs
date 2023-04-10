using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Cotrollers;



public class TarefaController:Controller {
    //view = pagina web 
    // funções 
    public IActionResult Index () {
        ViewData ["Cabecalho"] = "Tarefa Diária";
        ViewData ["Titulo"] = "Planejar Aula Senai";
        ViewData ["Descricao"] = "criar nova PEUC";
        return View ();
    }
}