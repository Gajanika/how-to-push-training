using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[] { 1, 2, 3, 4, 5, };
            //Console.WriteLine(num);
            //Console.ReadLine();




            //int[,] num2= new int[,]
            //{
            //    {45,20 },
            //    {44,22 },
            //    {77,33 },
            //    {78,66 },
            //    { 89,65},
            //    { 73,11},
            //};
            //Console.WriteLine(num2);
            //Console.ReadLine();




            //List<string> Name = new List<string>();
            //Name.Add("fff");
            //Name.Add("fgh");
            //Name.Add("fgh");
            //Name.Add("fgh");
            //Name.Add("fgh");
            //Console.WriteLine(Name);



            //List<int> num3 = new List<int>();
            //num3.Add(1);
            //num3.Add(2);
            //num3.Add(3);
            //num3.Add(4);
            //num3.Add(5);
            //int length = num3.Count;
            //Console.WriteLine(length);


            //Dictionary<int, string> IDAndName = new Dictionary<int, string>();
            //IDAndName.Add(1, "ggg");
            //IDAndName.Add(2, "lll");
            //IDAndName.Add(3, "fff");
            //foreach (var item in IDAndName) 
            //{
            //    Console.WriteLine(item);

            //}
            //Console.ReadLine ();


            //Stack <string> name = new Stack<string>();
            //name.Push("A");
            //name.Push("B");
            //name.Push("C");
            //name.Push("D");

            //Console.WriteLine(name.Pop());

            //Queue<string> names = new Queue<string>();
            //names.Enqueue("A");
            //names.Enqueue("B");
            //names.Enqueue("C");
            //names.Enqueue("D");

            //Console.WriteLine(names.Dequeue());


            //List<int> ints = new List<int>() { 1,2,3,4,5,6};
            //var evenNumber=ints.Where (Tt => Tt % 2 == 0);
            // foreach(var i in evenNumber) 
            //{
            //    Console.WriteLine(i);
            //}

            // Console.ReadLine();

            //List<string> strings = new List<string>() { "dgdey", "kdjwh", "ofuhefui" };
            //var sortedString = strings.OrderBy(s => s);
            //Console.WriteLine();
            //foreach (var str in sortedString) 
            //{
            //    Console.WriteLine(str);
            //
            //
            //
            //
            //int[] ints = { 1, 2, 3, 4, 5, };
            //var num=ints.Reverse();
            //foreach (int i in ints) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();




            //int[] ints = { 1, 2, 3 };
            //var num=ints.Max();
            //foreach (int i in ints) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();    



            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Count());
            //Console.ReadLine();


            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("a");
            //queue.Enqueue("b");
            //queue.Enqueue("c");
            // bool test=queue.Contains("a");
            //Console.WriteLine(test);


            //List<string> list = new List<string>();
            //list.Add("uyyt");
            //list.Add("ubhdfh");
            //list.Add("hvgd");
            //var lists = list.GroupBy(a => a[0]);
            //foreach (var group in lists)
            //{
            //  //// Console.WriteLine(group);
            //};

            // Console.ReadLine();


            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var sum = list.Sum();
            Console.WriteLine(sum);

            Console.ReadLine();







            //List<string> fruits= new List<string>();
            //fruits.Add("sss");
            //fruits.Add("HHHaH");
            //fruits.Add("aaa");
            //var startwith=  from str in fruits
            //                where str.Contains("a")
            //                select str;
            // foreach (var ggg in startwith)
            //{
            //    Console.WriteLine(ggg);
            //}
            // Console.ReadLine() ;   





        }


    }
}
