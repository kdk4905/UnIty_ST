using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player 
{
    // 객체화를 하지 않아도 그래도 플레이어의 내부는 내부이므로
    // 접근제한 지정자의 영향을 받지 않는다.
    public static void PVP(Player _Left, Player _Right) 
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }

    //public static void pve(player _left, monster _right)
    //{
    //    _left.hp -= _right.at;
    //    _right.hp -= _left.at;
    //}

    private int AT = 100;
    private int HP = 100;
    public void Damage(int _Dmg) 
    {
        HP -= _Dmg;
    }

    public void Damage(Player _Ohter)
    {
        // 자기자신의 래퍼런스는 자신의 내부에서
        // 모두 Public인 상태다.
        HP -= _Ohter.AT;
    }
}

public class Monster 
{
    private int AT = 100;
    //public static void PVP(Player _Left, Player _Right)
    //{
    //    _Left.HP -= _Right.AT;
    //    _Right.HP -= _Left.AT;
    //}
}

namespace _14_StaticFunc
{
    internal class Program
    {
        // 이녀석도 클래스에 속한 정적 함수이다.
        // 어떤 클래스에 존재하는 Main의 이름을 가진
        // 정적맴버함수에서부터 c# 프로그램은 시작한다.
        static void Main(string[] args)
        {
            // f12를 누르면 그 클래스로 타고 들어가볼수 있다.
            // 타고 들어간다는 것은
            // 그 클래스의 세부내용이 기록된 곳으로 간다.
            Console.WriteLine("static 함수 배우고 있어요");   

            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();

            // 마찬가지로 그 클래스에 속하지만
            // 객체를 굳이 만들지 않고도 사용할 수 있는
            // 함수를 정적맴버함수라고 한다.
            //Player.PVP(NewPlayer1, NewPlayer2);

            //NewPlayer1.Damage(100);
            // public인 맴버변수라도 이렇게 사용해야 한다.
            //NewPlayer.
        }
    }
}
