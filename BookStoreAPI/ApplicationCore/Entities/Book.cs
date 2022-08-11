using ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Book : BaseEntity
    {
        public string BookTitle { get; set; }
        public decimal Price { get; set; }
        public string Publisher { get; set; }   
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public BookTypes Genre { get; set; }
        public string Author { get; set; }
    }
}
