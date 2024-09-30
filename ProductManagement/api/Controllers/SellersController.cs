using domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SellersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var sellersFromRepo = await _unitOfWork.Seller.GetAllAsync();
            return Ok(sellersFromRepo);
        }


        [HttpGet("{sellerId}")]
        public async Task<ActionResult> GetById(int sellerId)
        {
            var seller = await _unitOfWork.Seller.GetByIDAsync(sellerId);
            return Ok(seller);
        }

        [HttpGet("{sellerId}/ProductsBySeller")]
        public async Task<ActionResult> GetProductBySeller(int sellerId)
        {
            var productsBySeller = await _unitOfWork.Seller.ProductsBySellerId(sellerId);
            return Ok(productsBySeller);
        }
    }
}
