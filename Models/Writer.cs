using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace IndyBooks.Models


{
    public class Writer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public ICollection<Book> Books { get; set; }
    }
}
