using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected int AT;

    public FightUnit()
    {
        int a = 0;   
    }
}

class Player : FightUnit
{
    // 생성자라고 합니다.
    // 특징
    // 리턴값이 없어요.
    // 생성자란
    // 만들어 질때 한번 실행되어주는 함수.

    // 눈에보이지 않지만 만들지 않아도 이 함수는 만들어진다.
    // 무조건 자신의 클래스의 메모리를 리턴해주는 함수이다.
    private Player()
    {
        AT = 100;

        int a = 0;
    }
}

namespace _24ClassConstructer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 의마가 있다.
            // Player NewPlayer = new Player();
        }
    }
}
