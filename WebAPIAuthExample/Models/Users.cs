using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIAuthExample.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        public int KiranaId { get; set; }
        [ForeignKey("KiranaId")]
        public required Company Company { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public required UserRoles Roles { get; set; }
    }
}
