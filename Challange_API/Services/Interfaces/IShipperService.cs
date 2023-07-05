using Challange_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IShipperService
{
    Task<List<string>> GetShipperNamesAsync();

    Task<IEnumerable<ShipperShipmentDetails>> GetShipperShipmentDetailsAsync(int shipperId);

}
