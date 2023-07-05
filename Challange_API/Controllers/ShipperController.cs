
using Microsoft.AspNetCore.Mvc;

namespace Challange_API.Controllers
{
    [ApiController]
    [Route("api/shippers")]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperService _shipperService;
        private readonly ILogger<ShipperController> _logger;

        public ShipperController(IShipperService shipperService, ILogger<ShipperController> logger)
        {
            _shipperService = shipperService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShippers()
        {
            try
            {
                var shippers = await _shipperService.GetShipperNamesAsync();
                var shipperNames = shippers.ToList();
                return Ok(shipperNames);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve Shippers");
                return StatusCode(500, "An error occurred while retrieving Shippers.");
            }
        }

        [HttpGet("{shipperId}")]
        public async Task<IActionResult> GetShipperDetails(int shipperId)
        {

            var shipmentDetails = await _shipperService.GetShipperShipmentDetailsAsync(shipperId);

            return Ok(shipmentDetails);
        }

    }
}
