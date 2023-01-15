using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 여러분이 왜 메모리를 알아야 하느냐?
// 메모리란 사실 c#을 배워야 하기 때문에 알아야 하는 게 아니다
// c#이 아니라 모든 프로그램의 근간이 되는 개념이기 때문입니다.
// 이 말은 무슨말이냐?
// 모든 프로그램은
// 공짜는 없다. 메모리를 지불한다.
// 메모리의 구조를 안다는 것은
// 코드의 동작원리를 아는 것과 같다.

class Player 
{
    int HP = 100;
    int AT = 10;

    // 함수의 인자값은
    // 지역변수이다.
    // int _Dmg 지역번수의 특징
    // 함수가 끝나면 사라진다.
    public void Damage(int _Dmg)
    { 
    
    }
}
// 객체로 만들기전

internal class Program
{
    // 요녀석을 메인 함수라고 하는데.
    // static을 빼면 함수의 모양을 가지고 있고
    // 함수
    // 이곳을 시작이라고 잡은 함수
    // c#의 규칙 Main 이라는 이름의 함수에서부터 시작한다.
    // 함수의 실행조차 공짜가 없다.
    static void Main(string[] args)
    {
        // 함수는 메모리화 되지 않는다.
        Console.WriteLine("메모리 1차 함수");

        // 지역변수 + a 로 계산되는데
        // 최소한 지역변수를 다 포함할 수 있는 크기만큼은
        // 크기가 되어야 한다.
        // 4바이트
        int Value = 0;

        // 객체를 만들었다.
        // 객체를 만들었다는 것은 메모리를 지불했다는 것.
        // 좀더 근본적인 내용은 무엇이냐?
        // 단하나도 공짜가 없다.
        // 어딘가에 만들어 졌다. (이녀석은 스택이 아니다.)
        Player NewPlayer = new Player();
        NewPlayer.Damage(10);
        // 이게 프로그램

    }
}
