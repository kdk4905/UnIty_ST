using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 멤버변수
    // 객체가 생기면 만들어지게 되는
    private int HP = 100;

    //public void Damage(int _Dmg) 
    //{
    //    // c#은 대체 어떻게????
    //    // 이 hp가 플레이어 2의
    //    // hp라는걸 알 수 있을까?

    //    //HP -= _Dmg;
    //    //this.HP -= _Dmg;
    //}

    // 멤버함수의 호출이란
    // 어차피 넣을거 내가 대신 넣어줄께.
    public void Heal(/*Player _this,*/ int _Heal)
    {
        // 맴버함수에서
        // 맴버변수를 쓴다면
        // 눈에보이지는 않지만
        // 앞에 this.이 생략된 것이다.
        // this.HP라는 것을 잊으면 은 안되는데
        // 섣불리 조금 언어를 배워놓고
        // 불어를 일주일 배우고
        // 영어를 불어를 기준으로
        // 이해하려고 하는건 굉장히 안좋다.
        HP += _Heal;
    }

    public static void Damage(Player _this, int _Dmg)
    {
        // Static 맴버함수는
        // 객체를 만들지 않고도 사용할 수 있으므로
        // 자신이라는 개념이 없는 함수이다.
        // this.HP;
        _this.HP -= _Dmg;
    }

    // 정적 맴버변수만을 정적 맴버함수에서 사용할 수 있다.
    private static int StTest = 100;
    static void PVP(Player _Left, Player _Right)
    {
        StTest = 50;
        // 객체에 영향을 받지 않는 것이
        // 정적 멤버함수 정적 맴버변수
        //HP = 1000;
    }

}

namespace _16This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            NewPlayer3.Heal(/*NewPlayer3, */100);

            // 문법적으로 
            // NewPlayer2.Heal(NewPlayer2, 100);

            Player.Damage(NewPlayer1, 100);
            //NewPlayer2.Damage(100);

        }
    }
}
