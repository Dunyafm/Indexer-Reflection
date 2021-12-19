using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerReflectionPractice.Models
{
    public class Book
    {
        public string  Name { get; set; }
        //ublic Book[] Books { get; set; }
        public override string ToString()
        {
            return Name;
        }       

    }
}
