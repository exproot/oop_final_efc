using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efc_console.Entities {
    public class Book 
        {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal Price { get; set; }

        // foreign key
        public int? CategoryId { get; set; }

        public Category Category { get; set; } // simple navigation property
        
        // navigation property
        public BookDetail BookDetail { get; set; }
    }
}
