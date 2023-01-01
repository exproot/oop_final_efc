using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efc_console.Entities {
    public class Book {
        [Key]
        public int BookId { get; set; }
        [Required]
        [MaxLength(50)]
        public string BookTitle { get; set; }
    }
}
