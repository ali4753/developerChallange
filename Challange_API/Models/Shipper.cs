using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Challange_API.Models
{
    public class Shipper
    {
        [Key]
        [Column("shipper_id")]
        public int ShipperId { get; set; }

        [Column("shipper_name")]
        public string ShipperName { get; set; }
    }

}
