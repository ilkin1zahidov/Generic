using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.Models
{
    public class MyList
    {
      
      
        public wish[] arr;
        public MyList()
        {
            arr = new wish[0];
        }
        public void add(wish wishlist )
        {
            Array.Resize(ref arr, arr.Length + 1);
               arr[arr.Length - 1] = wishlist;
        }
        public void getall()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.Id + "-" + item.Name);
            }
        }
    }
}
