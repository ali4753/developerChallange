namespace Challange_API.Services
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using Challange_API.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    public class ShipperService : IShipperService
    {
        private readonly ShipmentContext _dbContext;

        public ShipperService(ShipmentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<string>> GetShipperNamesAsync()
        {
            List<string> shipperNames = await _dbContext.Shippers
                .Select(s => s.ShipperName)
                .ToListAsync();

            return shipperNames;
        }

        public async Task<IEnumerable<ShipperShipmentDetails>> GetShipperShipmentDetailsAsync(int shipperId)
        {
            return await _dbContext.Shipper_Shipment_Details
                .FromSqlInterpolated($"EXECUTE dbo.Shipper_Shipment_Details {shipperId}")
                .ToListAsync();
        }

    }


}
