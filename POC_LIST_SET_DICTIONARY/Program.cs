using System;
using System.Collections.Generic;

namespace POC_LIST_SET_DICTIONARY
{
    class Program
    {
        static void Main(string[] args)
        {
            // list
            CaseStudy1();
            // set
            //CaseStudy2();
            // Dictionary
            //CaseStudy3();
        }
        public static void CaseStudy1()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Capacity of list is : " + list.Capacity);
            Console.WriteLine("No of elements in list " + list.Count);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            Console.WriteLine("No of elements in list " + list.Count);
            foreach(int no in list)
            {
                Console.WriteLine(no + " ");
            }
            Console.WriteLine("\nLet us remove the elements now");
            list.RemoveAt(0);
            Console.WriteLine("After removing one element from list , size of list is : " + list.Count);
            list.RemoveAt(2);
            Console.WriteLine("We removed one more element");
            foreach (int no in list)
            {
                Console.WriteLine(no + " ");
            }
            Console.WriteLine("Let us insert element directly in required index");
            list.Insert(1, 90);
            list.Insert(3, 1000);
            foreach (int no in list)
            {
                Console.WriteLine(no + " ");
            }
            Console.WriteLine("Now let us what is index of 1000 : " + list.IndexOf(1000));
            Console.WriteLine("Now let us remove element without giving its index");

            list.Remove(90);
            foreach (int no in list)
            {
                Console.WriteLine(no + " ");
            }
            Console.WriteLine("Let us find out what is type of list " + list.GetType());
            Console.WriteLine("Now let us sort the list and see what happens");
            list.Sort();
            foreach (int no in list)
            {
                Console.WriteLine(no + " ");
            }
            Console.WriteLine("Now let us reverse the list ");
            list.Reverse();
            foreach (int no in list)
            {
                Console.WriteLine(no + " ");
            }
            list.Clear();
            Console.WriteLine("We cleared the list now " + list.Count);
        }
        public static void CaseStudy2()
        {
            HashSet<int> st1 = new HashSet<int>();
            Console.WriteLine("No of elements in set is " + st1.Count);
            Console.WriteLine("Let us add element ");
            st1.Add(10);
            Console.WriteLine("No of elements in set is " + st1.Count);
            foreach (int no in st1)
            {
                Console.WriteLine(no);
            }
            Console.WriteLine("Now let us add the same elemetn again ");
            st1.Add(10);
            Console.WriteLine("No of elements in set is " + st1.Count);
            foreach (int no in st1)
            {
                Console.WriteLine(no);
            }
            Console.WriteLine("You can see the that the same element is not added again ");
            Console.WriteLine("Set contains only unique elements of similar kind");
            Console.WriteLine("Now let us add some more elements to do more the operations");
            st1.Add(20);
            st1.Add(30);
            st1.Add(40);
            st1.Add(50);
            foreach (int no in st1)
            {
                Console.WriteLine(no);
            }
            Console.WriteLine("Now we have enough elements , let us remove some elements \nWe have removed the '10' value from set");
            st1.Remove(10);
            Console.WriteLine("No of elements in set is " + st1.Count);
            foreach (int no in st1)
            {
                Console.WriteLine(no);
            }
            Console.WriteLine("Let us do some set operations , intersection and Union\nHere we declared another set for our ops");
            HashSet<int> st2 = new HashSet<int>();
            st2.Add(30);
            st2.Add(40);
            st2.Add(50);
            st2.Add(60);
            st2.Add(70);
            Console.WriteLine("No of elements in set is " + st2.Count);
            foreach (int no in st2)
            {
                Console.WriteLine(no);
            }
            Console.WriteLine("Now we will modify the st1 with st2 using union operation");
            st1.UnionWith(st2);
            Console.WriteLine("No of elements in set is " + st1.Count);
            foreach (int no in st1)
            {
                Console.WriteLine(no);
            }
            // after modifying the st1 , we are removing the st2 elements from st1
            st1.Remove(70);
            st1.Remove(60);
            Console.WriteLine("Now we will find the intersection of two sets");
            st1.IntersectWith(st2);
            Console.WriteLine("No of elements in set is " + st1.Count);
            foreach (int no in st1)
            {
                Console.WriteLine(no);
            }
        }
        public static void CaseStudy3()
        {
            IDictionary<int, string> dict1 = new Dictionary<int, string>();
            Console.WriteLine("Size of dictionary : " + dict1.Count + "\nNow let us some pairs in dictionary");
            dict1.Add(1, "Mumbai");
            dict1.Add(2, "Pune");
            dict1.Add(3, "Hyderabad");
            dict1.Add(4, "Banglore");
            dict1.Add(5, "Delhi");
            foreach(KeyValuePair<int,string> dictionary in dict1)
            {
                Console.WriteLine("Key : " + dictionary.Key + " Value : " + dictionary.Value);
            }
            Console.WriteLine("We can also access the dictionary elements randomly using key");
            Console.WriteLine(dict1[1]);
            Console.WriteLine("For removing elements from dictionary we have to use the key\n");
            dict1.Remove(1);
            dict1.Remove(2);
            foreach (KeyValuePair<int, string> dictionary in dict1)
            {
                Console.WriteLine("Key : " + dictionary.Key + " Value : " + dictionary.Value);
            }
            Console.WriteLine("We can also declare the dictionary like this ");
            var dict2 = new Dictionary<string, string>(){
                {"UK","London"},
                {"USA","Chicago"},
                {"India","Mumbai"}
            };
            foreach(KeyValuePair<string,string> dictionary in dict2)
            {
                Console.WriteLine("Key : " + dictionary.Key + " Value : " + dictionary.Value);
            }
        }
    }
}