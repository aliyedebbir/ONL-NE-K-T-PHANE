using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        [Required]
        [Display(Name = "Yayın Evi")]
        public string PublisherName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
