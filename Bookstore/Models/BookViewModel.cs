﻿using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class BookViewModel
    {
        // ********************* BOOK DATA *********************

        [StringLength(350)]
        public string BookTitle { get; set; }

        [Display(Name = "Author")]
        public string AuthorName { get; set; }

        [Display(Name = "Author")]

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

        [Display(Name = "Publisher")]

        public int PublisherID { get; set; }

        public int UserId { get; set; }

        [StringLength(150)]
        public string Genre { get; set; }

        [Display(Name = "Category")]

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

        // ********************* AUTHOR DATA *********************
        [StringLength(100)]
        public string AuthorNameDTO { get; set; }

        [StringLength(100)]
        public string AuthorCountryDTO { get; set; }

        public DateTime AuthorDateBirthDTO { get; set; }

        [StringLength(500)]
        public string AuthorShortDescriptionDTO { get; set; }

        [StringLength(50)]
        public string AuthorLanguageDTO { get; set; }

        [StringLength(50)]
        public string AuthorGenderDTO { get; set; }

        public bool AuthorPopularityDTO { get; set; }

        // ********************* CATEGORY DATA *********************

        public string CategoryNameDTO { get; set; }

        // ********************* PUBLISHER DATA *********************

        [StringLength(100)]
        public string PublisherNameDTO { get; set; }

        [StringLength(100)]
        public string PublisherCountryDTO { get; set; }

        [StringLength(50)]
        public string PublisherYearDTO { get; set; }
    }
}
