using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name="Kategori Adı")]
        public string Name { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
