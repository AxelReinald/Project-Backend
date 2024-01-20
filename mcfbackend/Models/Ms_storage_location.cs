using System.ComponentModel.DataAnnotations;

namespace mcfbackend.Models
{
    public class Ms_storage_location
    {
        [Key]
        public string location_id { get; set; }
        public string location_name { get; set; }
    }
}
