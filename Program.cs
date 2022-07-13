using Generic.Models;
using System;

namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
           

            wish wishlist = new wish
            {
                Id = 1,
                Name = "Bmw"

            };
           
            myList.getall();

            wish wishlist2 = new wish
            {
                Id = 2,
                Name = "Mercedes"
            };

            myList.add(wishlist);
            myList.add(wishlist2);



            myList.getall();

        }
    }
   
    public class wish
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
