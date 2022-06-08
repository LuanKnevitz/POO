using Ap2_1.Models.Domain;
using Ap2_1.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ap2_1.Controllers;

[ApiController]
[Route("[controller]")]
public class BillingController : ControllerBase
{
    private readonly IBillingRepository BillingRepository;

    public BillingController(IBillingRepository billingRepository)
    {
        BillingRepository = billingRepository;
    }

     
    [HttpGet]
    public IEnumerable<Billing> GetBillings()
    {
        return BillingRepository.GetAll();
    }

    
    [HttpGet("{id:int}")]
    public ActionResult GetBillingById(int id)
    {
        return Ok(BillingRepository.GetById(id));
    }

    
    [HttpPost]
    public IActionResult InsertBilling([FromBody] Billing billing)
    {  
        BillingRepository.Insert(billing);
        return Ok(billing);
    }

    [HttpPut]
    public ActionResult UpdateBilling([FromBody] Billing billingToBeUpdated)
    {
        BillingRepository.Update(billingToBeUpdated);
        return Ok("Charge Updated.");
    }

    [HttpDelete("{id:int}")]
    public ActionResult DeleteBilling(int id)
    {
        BillingRepository.Delete(id);
        return Ok("Charge deleted.");
    }
}