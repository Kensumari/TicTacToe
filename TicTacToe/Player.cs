using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        int inputNumber;
        string input;


        public List<int> P1List = new List<int>();
        public List<int> P2List = new List<int>();
        public List<int> TotalList = new List<int>();

        bool isInList = false;

        public void P1()
        {
            inputNumber = 10;
            isInList = true;
            while (inputNumber > 9 || inputNumber < 1 || isInList == true)
            {
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("You need to write a number.");
                }
                else
                {
                    isInList = TotalList.Contains(inputNumber);
                    if (isInList == false)
                    {
                        P1List.Add(inputNumber);
                        TotalList.Add(inputNumber);
                    }
                    else
                    {
                        Console.WriteLine("You can not have a unit there. There is already a unit in there.");
                    }
                    if (inputNumber > 9 || inputNumber < 1)
                    {
                        Console.WriteLine("You may only type numbers between 1-9");
                    }
                }
            }
        }
        public void P2()
        {
            inputNumber = 10;
            isInList = true;
            while (inputNumber > 9 || inputNumber < 1 || isInList == true)
            {
                input = Console.ReadLine();
                if(!Int32.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("You need to write a number.");
                }
                else
                {
                    isInList = TotalList.Contains(inputNumber);
                    if (isInList == false)
                    {
                        P2List.Add(inputNumber);
                        TotalList.Add(inputNumber);
                    }
                    else
                    {
                        Console.WriteLine("You can not have a unit there. There is already a unit in there.");
                    }
                    if (inputNumber > 9 || inputNumber < 1)
                    {
                        Console.WriteLine("You may only type numbers between 1-9");
                    }
                }
            }
        }
    }
}
