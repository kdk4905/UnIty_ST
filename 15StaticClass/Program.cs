using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적 클래스란
// 정적 맴버변수와
// 정적 맴버함수만을 가질수 있는 클래스이다.
static class StClass
{
    // 일반 맴버변수는 선언만해도 오류가 나게 된다.
    // int TEST = 100;
}

class Player 
{
    // 함수의 위치는 문법적으로는 어디에 있건
    // 상관 없다.
    // 구조적으로 이야기하는 것이 아니라.
    static int Number = 100;

    static void Main(string[] args)
    {
        Console.WriteLine("Console.WriteLine은...은 정적 멤버함수에요");
    }

}

namespace _15staticClass
{
    internal class Program
    {

    }
}
