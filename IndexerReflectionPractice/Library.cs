using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerReflectionPractice.Models
{
    public  class Library
    {
        public string Name { get; set; }
        private Book[] _Books;

        public Library(int size = 100)
        {
            _Books = new Book[size];

        }
        public Book this[int index]
        {
            get
            {
                return _Books[index]; 
            }
            set
            {
                _Books[index] = value;
            }
        }
        
        
        
    }

}
