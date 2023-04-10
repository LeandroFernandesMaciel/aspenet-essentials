//namespace é um conjunto de obetos 
//propriedades automaticas

namespace GerenciaTarefa.Models;
public class Tarefa {
//classe é um conjunto de objetos 
//propriedades 
    public int id {get; set; }// inteiro
    public string? Cabecalho {get; set;}// texto
    public string? Titulo {get; set;}// texto
    public string? Descricao {get; set;}// texto    

    public bool TaCompleta { get; set; }
//funcionalidades 


}