using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int AT = 10;
    public int HP = 100;

    // Monster _Monster 클래스가 객체화된 녀석을 받았다.
   public void ATT(Monseter _Monster) 
    {
        _Monster.HP -= AT;
    }
}

class Monseter
{
    public int AT  = 10;
    public int HP = 100;

    // 함수의 추가 설명
    public  void ATT(Player _Player)
    {
        // 플레이어의 HP는 얼마일까요?
        // 100

        _Player.HP -= AT;
        // 90
    }
}


namespace _12Memory02_Reference_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 값형과 레퍼런스 형을 구분할줄 알아야 한다.
            // 기본자료형을 선언만 하면 그녀석들은 값형이다.
            
            // 자기가 만든 클래스를 new 클래스명();
            // 해서 만든것을 그 클래스명에 받으면
            // 그건 레퍼런스 형이다.

            // 클래스가 객체화된 녀석은
            // 래퍼런스 형이라고 하는 자료형이 되고
            
            // 여러분들이 여태까지 봐왔던
            // int bool 이런 녀석들은
            // 값형이라고 한다.

            // 이 값형과 레퍼런스형은
            // 메모리의 위치와 사용법이 다르기 때문에
            // 다르게 동작한다.

            // HP 100 AT 10
            // 이 레퍼런스라고 하는 녀석은
            // 힙에 생성된 어떠한 메모리의 위치를 가리키는 값이다.
            // 클래스를 자료형으로 만든 레퍼런스의 역할은
 
            Monseter NewMonster = new Monseter();

            // HP 100 AT 10
            Player NewPlayer = new Player();          
            // 얕은 이해.
            // 안에 값을 끌어내고 싶으면 . 누르면 끌어내진다.
            // 정확한 이해.
            // 내가 가리키고 있는
            // 위치에 있는 HP를 사용하겠다.

            //NewPlayer.

            // 우리가 전강의에서 배웠던 대로라면
            // 플레이어가 자신의 공격력으로
            // 몬스터를 때린거죠
            // 하지만 적용될리가 없죠?
            // 잘못 이해할수있거나 오해하실수 있다.
            // 둘의 HP는 90으로 깎이게 된다.
            // 제가 원하는건 그림으로 그려보면서
            // 이거 결과 그냥 봤으니까요.
            NewMonster.ATT(NewPlayer);
            NewPlayer.ATT(NewMonster);
            // 플레이어의 HP가 깍인것이 보인다.

        }
    }
}
