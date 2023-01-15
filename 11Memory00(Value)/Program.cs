using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player 
{
    int AT;
    int HP;

    public int Test(int _Dmg)
 
    {
        // 이안에 지역변수에서 벌이지는 일은
        // 이 안에서 벌어지는 일일 뿐이다.
        _Dmg = 1000;

        return _Dmg;
    }

}

namespace _11Memory00_Value_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();

            // 함수의 인자값.
            int Value = 100;
            Newplayer.Test(Value);

            // 지금 까지 배운 문법으로는 절대로 불가능하다.
            // 그러면 어떻게 해야 하는가?
            // 이렇게 처리해줘야 됩니다.
            // 이걸 값형의 처리.
            Value = Newplayer.Test(Value);


            // 보통 2가지로 나뉜다.
            // 0이다.
            // 0이 나올것이다.

            // 1000이다. -> 이걸 말한다.
            // 왜냐 아직 메모리를 이해하지 못했다.
            // 데이터의 흐름을 이해하고 있지 못하다.
            // 왜 1000이 나오지 않죠?????
            // 이걸 이해하려면
            // 값과 위치에 대해서 이해해야 합니다.

            Console.WriteLine(Value);
        }
    }
}
