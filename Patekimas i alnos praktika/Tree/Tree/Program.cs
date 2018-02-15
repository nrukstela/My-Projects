using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainBranch = new Branch();
            var branch2= new Branch();
            var branch3 = new Branch();
            var branch4 = new Branch();
            var branch5 = new Branch();
            var branch6 = new Branch();
            var branch7 = new Branch();
            var branch8 = new Branch();
            var branch9 = new Branch();
            var branch10 = new Branch();
            var branch11 = new Branch();
            
            // Main Branch has 2 smaller branches (depth level 2)
            mainBranch.Branches.Add(branch2);
            mainBranch.Branches.Add(branch3);
            // Left Branch has 1 smaller branch (depth level 3)
            branch2.Branches.Add(branch4);
            // Right Branch has 3 smaller branches (depth level 3)
            branch3.Branches.Add(branch5);
            branch3.Branches.Add(branch6);
            branch3.Branches.Add(branch7);
            // Left Branch has 1 smaller branch (depth level 4)
            branch5.Branches.Add(branch8);
            // Middle Branch has 2 smaller branches (depth level 4)
            branch6.Branches.Add(branch9);
            branch6.Branches.Add(branch10);
            // Left Branch has 1 smaller branch (depth level 5)
            branch9.Branches.Add(branch11);

            Console.WriteLine("Lowest level is "+Branch.GetDepth(mainBranch));





            //                                                 Another option which is simple to understand

            var level1 = new Branch();
            var level2 = new Branch();
            var level3 = new Branch();
            var level4 = new Branch();
            var level5 = new Branch();
            var level6 = new Branch();
            var level7 = new Branch();
            var level8 = new Branch();
            var level9 = new Branch();
            var level10 = new Branch();
            var level11 = new Branch();

            level1.Branches.Add(level2);
            level2.Branches.Add(level3);
            level3.Branches.Add(level4);
            level4.Branches.Add(level5);
            level5.Branches.Add(level6);
            level6.Branches.Add(level7);
            level7.Branches.Add(level8);
            level8.Branches.Add(level9);
            level9.Branches.Add(level10);
            level10.Branches.Add(level11);

            Console.WriteLine("Lowest level is "+Branch.GetDepth(level1));
            Console.ReadLine();
        }
    }
}
