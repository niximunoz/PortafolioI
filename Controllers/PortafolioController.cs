using Microsoft.AspNetCore.Mvc;

namespace PortafolioI.Controllers;

public class PortafolioController : Controller{
    [HttpGet("")]
    public string Index(){
        return "This is my Index!";
    }

    [HttpGet("projects")]
    public string Projects(){
        return "These are my projects";
    }
    [HttpGet("contact")]
    public string Contact(){
        return "This is my Contact!";
    }
    
}