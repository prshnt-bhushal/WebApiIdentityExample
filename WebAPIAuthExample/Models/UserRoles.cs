using System.ComponentModel.DataAnnotations;

namespace WebAPIAuthExample.Models
{
    public class UserRoles
    {
        [Key]
        public int RoleId { get; set; }
        public required string RoleName { get; set; }

        public required ICollection<Users> Users { get; set; }

    }
}
