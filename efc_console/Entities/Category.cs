using System.Collections.Generic;

namespace efc_console.Entities {
    public class Category {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDesc { get; set; }

        // collection navigation property
        public ICollection<Book> Books { get; set; }
    }
}
