using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EndGameEntityDB.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID { get; set; }

        [Required]
        public string ChatMessage { get; set; }

        [Required]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        [Required]
        public DateTime MessageCreated { get; set; }
    }
}
