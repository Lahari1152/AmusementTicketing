using BusinessLayer.Services;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        public PurchaseService _purchaseService;

        public PurchaseController(PurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }
        [HttpGet]
        public IActionResult GetAllPurchases()
        {
            var allPurchases = _purchaseService.GetAllPurchases();
            return Ok(allPurchases);
        }

        [HttpGet("{id}")]
        public IActionResult GetPurchaseById(int id)
        {
            var purchase = _purchaseService.GetPurchaseById();
            return Ok(purchase);
        }

        [HttpPost]
        public IActionResult AddPurchase([FromBody] Purchase purchase)
        {
            _purchaseService.AddPurchase(purchase);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePurchaseById(int id, [FromBody] Purchase purchase)
        {
            var updatePurchase = _purchaseService.UpdatePurchaseById(id, purchase);
            return Ok(updatePurchase);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletePurchaseById(int id)
        {
            _purchaseService.DeletePurchaseById(id);
            return Ok();
        }
    }
}
