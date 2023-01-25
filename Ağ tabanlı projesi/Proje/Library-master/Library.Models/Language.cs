using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Language
    {
        public int LanguageId { get; set; }

        [Required]
        [Display(Name = "Dil")]
        public string LanguageName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
