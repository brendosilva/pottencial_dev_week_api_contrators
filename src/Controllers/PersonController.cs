using Microsoft.AspNetCore.Mvc;

using pottencial_dev_week.src.Models;
using pottencial_dev_week.src.Persistence;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{

    public PersonController(DatabaseContext context)
    {
        this._repository = context;
    }

    private DatabaseContext _repository { get; set; }

    [HttpGet]
    public List<Person> get()
    {        
       return _repository.Persons.ToList();        
    }

    [HttpPost]
    public Person Post(Person person)
    {
        _repository.Persons.Add(person);
        _repository.SaveChanges();
        return person;
    }

    [HttpPut("{id}")]
    public Person update ([FromRoute] int id, [FromBody] Person person) {
        _repository.Persons.Update(person);
        _repository.SaveChanges();
        
        return person;
    }
}