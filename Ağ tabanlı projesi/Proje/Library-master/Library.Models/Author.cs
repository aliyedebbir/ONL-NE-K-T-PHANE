using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        
        public virtual ICollection<Book> Book { get; set; }
    }
}
