using System.ComponentModel.DataAnnotations;

namespace WebAPIAuthExample.Models
{
    public class Company
    {
        [Key ]
        public int KiranaId { get; set; }
        public required string KiranaName { get; set; }

        public string KiranaLocation { get; set; } = string.Empty;

        public DateTime RegisteredDate { get; set; }

        public required ICollection<Users> Users { get; set; }

    }
}
