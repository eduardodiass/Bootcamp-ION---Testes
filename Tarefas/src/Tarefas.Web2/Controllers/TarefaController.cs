using Microsoft.AspNetCore.Mvc;
using Tarefas.web2.Models;

namespace Tarefas.Web2.Controllers;

public class TarefaController : Controller
{


    public IActionResult Index(){
        return View();
    }
    
    public IActionResult Create(){

        return View();
    }

    public IActionResult Details(int id)
    {
        return View();
    }
    public IActionResult Delete()
    {
        return View();
    }



}