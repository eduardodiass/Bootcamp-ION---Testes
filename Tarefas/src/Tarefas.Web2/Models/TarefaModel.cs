

using System.ComponentModel;

namespace Tarefas.web2.Models {

    public class TarefaModel{
    
    public int Id {get;set;}
    [DisplayName("Título")]
    public string Titulo {get;set;}
    [DisplayName("Descrição")]
    public string Descricao{get;set;}
    public DateTime DataInicio{get;set;}
    public DateTime DataFim{get;set;}
   




    }









}