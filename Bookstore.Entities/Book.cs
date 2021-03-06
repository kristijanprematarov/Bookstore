using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bookstore.Entities
{
    public class Book
    {
        [Key]

        public int Id { get; set; }

        [StringLength(350)]
        public string Title { get; set; }

        [Display(Name = "Author")]
        public string AuthorName { get; set; }

        [Display(Name = "Author ID")]

        public int AuthorID { get; set; }
        public Author Author { get; set; }

        [Display(Name = "Year of issue")]

        public DateTime YearOfIssue { get; set; }

        [Display(Name = "Pages")]

        public int NumberOfPages { get; set; }

        [StringLength(350)]
        [Display(Name = "Publisher")]

        public string PublisherName { get; set; }
        public Publisher Publisher { get; set; }

        [Display(Name = "Publisher ID")]

        public int PublisherID { get; set; }

        public int UserId { get; set; }

        [StringLength(150)]
        public string Genre { get; set; }

        [Display(Name = "Category ID")]

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [StringLength(150)]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        public double Price { get; set; }

        [StringLength(50)]
        [Display(Name = "Book type")]
        public string BookType { get; set; } //EBook, AudioBook, Physical Book

        [StringLength(50)]
        [Display(Name = "Book cover type")]
        public string BookCoverType { get; set; } //Cover type

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]

        public string Language { get; set; }

        [StringLength(150)]

        public string Country { get; set; }

        public int Edition { get; set; }

        [StringLength(50)]

        public string Dimensions { get; set; }

        public double Weight { get; set; }

        public double Copies { get; set; }

        [StringLength(50)]

        public string Shipping { get; set; }

        [Display(Name = "Photo")]

        public string PhotoURL { get; set; } // za cover slikata !!!

        [Display(Name = "Sold items")]

        public int SoldItems { get; set; }

        public double Rating { get; set; }

        [Display(Name = "Date added")]

        public DateTime DateAdded { get; set; }

        //public ICollection<Photo> Photos { get; set; }
    }
}
