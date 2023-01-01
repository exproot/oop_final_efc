using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efc_console.Entities {
    public class Book {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
