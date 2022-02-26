using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
        }

        static void Problem1()
        {
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("When you post a message on Facebook, depending on the number of people " +
                "\nwho like your post, Facebook displays different information:" +
                "\n- If no one likes your post, it doesn't display anything." +
                "\n- If only one person likes your post, it displays: [Friend's Name] likes your post" +
                "\n- If two people like your post, it displays: [Friend 1] and[Friend 2] like your post." +
                "\n- If more than two people like your post, it displays: [Friend 1], [Friend 2] and" +
                "\n[Number of Other People] others like your post." +
                "\nWrite a program and continuously ask the user to enter different names, until the user " +
                "\npresses Enter(without supplying a name).Depending on the number of names provided, " +
                "\ndisplay a message based on the above pattern.You should use a List when solving this one!");
            Console.WriteLine("*******************************************************************************************");
            var list = new List<Tuple<string, string>>();
            string name, like;
            int ct = 0;
            do
            {
                Console.Write("Enter \"Friend's\" name: ");
                name = Console.ReadLine();
                if (name != "")
                {
                    Console.Write("Does " + name + " like the post (y or n): ");
                    like = Console.ReadLine();
                    Console.WriteLine("");
                }
                else { break;  }

                
                if (like == "y")
                {
                    list.Add(new Tuple<string, string>(name, like));
                }
                
                

            } while (name != "");

            int size = list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Item2 == "y")
                {
                    ct += 1;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (ct == 1)
            {
                Console.WriteLine(list[0].Item1 + " likes your post");
            }
            else if (ct == 2)
            {
                Console.WriteLine(list[0].Item1 + " and " + list[1].Item1 + " like your post");
            }
            else if (ct > 2)
            {
                int rem = ct - 2;
                if (rem > 1)
                {
                    Console.WriteLine(list[0].Item1 + ", " + list[1].Item1 + " and " + rem + " others like your post");
                }

                else
                {
                    Console.WriteLine(list[0].Item1 + ", " + list[1].Item1 + " and " + rem + " other like your post");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Problem2()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("Write a program that asks the user to enter a sentence. Display each unique letter in the " +
                "\nsentence, and how many times each one appeared. You should use a Dictionary when " +
                "\nsolving this one!");
            Console.WriteLine("*******************************************************************************************");
            Dictionary<string, int> stringList = new Dictionary<string, int>();

            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            
            foreach (char ch in s)
            {
                String cStrg = ch.ToString();
                //Console.WriteLine(ch);
                if (stringList.ContainsKey(cStrg))
                {
                    stringList[cStrg] += 1;
                }
                else
                {
                    stringList.Add(cStrg, 1);
                }
            }
            stringList.Remove(" ");
            int count3 = stringList.Count;
            /*for (int i = 0; i < count3; i++)
            {
                Console.WriteLine(stringList.ElementAt(i).Key + "  " + stringList.ElementAt(i).Value);
            }*/
            Console.WriteLine("");
            foreach (KeyValuePair<string, int> a in stringList)
            {
                Console.WriteLine(a.Key + "  " + a.Value);
            }


        }
    }

    
}
