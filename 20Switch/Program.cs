using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{

    internal class Program
    {
        static int Number() 
        {
            return 50;
        }
        static void Main(string[] args)
        {
            int Left = 100;
            int Right = 10;

            if (Number() == 50)
            {

            }

            if (Left > Right)
            {

            }

            int SwitchTest = 100;

            // 이녀석은 == 연산밖에 못합니다.

            switch (SwitchTest)
            {
                // case Test1: // 변수는 안됩니다.
                // 오로지 상수와만 비교할 수 있다.
                case 0:
                case 1:
                    Console.WriteLine("SwitchTest 는 0 또는 1 입니다.");
                    //Console.WriteLine("SwitchTest 는 1 입니다.");
                    break;
                case 100:
                    Console.WriteLine("SwitchTest 는 100 입니다.");
                    break;
                default: // else의 역할을 한다.
                    Console.WriteLine("모든 조건이 맞지 않습니다.");
                    break;
            }
        }
    }
}
