using IndexerReflectionPractice.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace IndexerReflectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Indexser

            //List<int> nums = new List<int>();
            //nums.Add(5);
            //nums.Add(2);
            //nums.Add(1);
            //nums.Add(7);

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    if(nums[i]==1)
            //    { //Console.WriteLine(nums[0]);

            //        Console.WriteLine(i);
            //        break;
            //    }

            //}

            //console.WriteLine(nums[0]);


            //Bird bird = new Bird();
            //var result = bird.convertstringtonum("55");
            //Console.WriteLine(result);

            //Book book1 = new Book
            //{
            //    Name = "Sedaqetli"
            //};

            //Library library = new Library();
            //library[0] = book1;
            //Console.WriteLine(library[0]);

            #endregion

         Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (var item in assembly.GetTypes())
            {
                Console.WriteLine();
                foreach (var item2 in item.GetMembers())
                {
                    Console.WriteLine(item2);
                }



            }
             
                                       
                

                
            

            

            //Book book = new Book
            //{
            //    Id = 1,
            //    Name = "Xosrov ve Shirin",
            //    Author = "Nizami"
            //};

            //var result = GetBook(book);
            //Console.WriteLine(result);

            //Console.WriteLine(book.ToString());


        }
        //ublic static Book GetBook(Book book) 
        //{
        //eturn book;
        //}
    }

    //lass Book 
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Author { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Name} - {Author}";
    //    }

}
    //class Animal
    //{
    //    public int Age { get; set; }
    //    public virtual int convertstringtonum(string age)
    //    {
    //        return 5;

    //    }

    //}
    //class Bird : Animal 
    //{

    //    public override int convertstringtonum(string age)
    //    {
    //        return  Convert.ToInt32(Age);
    //    }




    //}
        
        
        
    




