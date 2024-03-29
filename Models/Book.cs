﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        //[Display(Name = "Book Name")]
        public string Name { get; set; }

        public string Author { get; set; }

        [DataType(DataType.Currency)]
        [Range(0.01,100.00, ErrorMessage ="Price should be between £0.01 and £100")]
        public double Price { get; set; }
    }
}
