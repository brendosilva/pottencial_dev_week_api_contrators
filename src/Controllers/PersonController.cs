using Microsoft.AspNetCore.Mvc;
using pottencial_dev_week.src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{

    [HttpGet]
    public Person get()
    {
        Person pessoa = new Person("Brendo", 24, "25287412");
        Contract contract = new Contract("abscr", 50.99);
        pessoa.Contracts.Add(contract);
        
        return pessoa;
    }
    [HttpPost]
    public Person Post(Person person)
    {
        return person;
    }

    [HttpPut("{id}")]
    public string update ([FromRoute] int id) {
        return "dados do id " + id + " atualizados!!!";
    }
}