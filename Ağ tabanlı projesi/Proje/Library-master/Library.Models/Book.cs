using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Özet")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Fiyat")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Stok Miktarı")]
        [Range(0, 1000, ErrorMessage = "Stok Miktarı 0 ile 10000 arasında olmalıdır.")]
        [Required]
        public short UnitInStock { get; set; }

        [Display(Name = "Sayfa Sayısı")]
        [Required]
        public int Page { get; set; }

        [Display(Name = "Baskı")]
        [Range(0, 1000, ErrorMessage = "Baskı Miktrı 0 ile 10000 arasında olmalıdır.")]
        [Required]
        public short Edition { get; set; }
        
        [Display(Name = "Basım Tarihi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime PublishDate { get; set; }

        [Display(Name = "Resim")]
        [Required]
        public string ImageUrl { get; set; }

        [Display(Name = "ThumbnailUrl")]
        [Required]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Kategori")]
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "Dil")]
        [Required]
        public int LanguageId { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }

        [Display(Name = "Yayın Evi")]
        [Required]
        public int PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }

        [Display(Name = "Yazar")]
        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        public virtual ICollection<Buy> Loan { get; set; }
    }
}
