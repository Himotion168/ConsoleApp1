using System;
using System.Collections.Generic;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Student outterStu = new Student() { Name="Tim"};
            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
            Console.WriteLine("hashcode of x={0},x={1}", x.GetHashCode(), x);
            Console.WriteLine("-----------------------");

            IWantSideEffect(ref outterStu,ref x);
            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
            Console.WriteLine("hashcode of x={0},x={1}", x.GetHashCode(), x);

            Console.ReadLine();
        }

        static void IWantSideEffect(ref Student stu,ref int x)
        {
            //stu = new Student() { Name="Tom"};
            stu.Name = "Hello";
            Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(),stu.Name);
            Console.WriteLine("hashcode of x={0},x={1}",x.GetHashCode(),x);
            x += 100;
        }

    }

    class Student
    {
        public string Name{ get; set; }
    }

}

