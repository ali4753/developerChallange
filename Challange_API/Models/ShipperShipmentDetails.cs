using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challange_API.Models
{
    public class ShipperShipmentDetails
    {
        [Key]
        [Column("shipment_id")]
        public int ShipmentId { get; set; }
        [Column("shipper_name")]
        public string ShipperName { get; set; }
        [Column("carrier_name")]
        public string CarrierName { get; set; }
        [Column("shipment_description")]
        public string ShipmentDescription { get; set; }
        [Column("shipment_weight")]
        public decimal ShipmentWeight { get; set; }
        [Column("shipment_rate_description")]
        public string ShipmentRateDescription { get; set; }
    }

}
