using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EndGameEntityDB.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [MaxLength(50), MinLength(1)]
        [Index(IsUnique = true)]
        [Required]
        public string UserName { get; set; }

        [MaxLength(62), MinLength(1)]
        [Required]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
