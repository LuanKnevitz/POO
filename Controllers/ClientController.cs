using Ap2_1.Models.Domain;
using Ap2_1.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ap2_1.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientRepository ClientRepository;

    public ClientController(IClientRepository clientRepository)
    {
        ClientRepository = clientRepository;
    }

     
    [HttpGet]
    public IEnumerable<Client> GetCLients()
    {
        return ClientRepository.GetAll();
    }

    
    [HttpGet("{id:int}")]
    public ActionResult GetClientById(int id)
    {
        return Ok(ClientRepository.GetById(id));
    }

    
    [HttpPost]
    public IActionResult InsertClient([FromBody] Client client)
    {
        ClientRepository.Insert(client);
        return Ok(client);
    }

    [HttpPut]
    public ActionResult UpdateClient([FromBody] Client clientToBeUpdated)
    {
        ClientRepository.Update(clientToBeUpdated);
        return Ok("Client Updated.");
    }

    [HttpDelete("{id:int}")]
    public ActionResult DeleteClient(int id)
    {
        ClientRepository.Delete(id);
        return Ok("Client deleted.");
    }
}