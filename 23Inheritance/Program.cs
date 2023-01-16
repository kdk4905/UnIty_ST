using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 방법은
// 공통되는 기능을 하는 맴버변수와
// 맴버함수를 걷어낸다.
// 새로운 클래스에 그 모든 멤버변수와 함수를 넣는다.
// 상속시킨다.

class FightUnit 
{
    //          외부        자식         나
    //          public      protected    private(디폴트)
    // 범위     외부까지    자식까지     나까지

    protected int AT = 10;
    protected int HP = 100;

    public void Damage(/*FightUnit .this,*/FightUnit _OhterUnit)
    {
        // 나는 fightUnit지만 
        // 이안에서 플레이어의 기능을 쓰고 싶은것.
        // 다운캐스팅
        // 다운캐스팅은 최대한 지양(피하라.)
        // 플레이어를 실수로 몬스터로 변경할수도 있게 된다.
        // Player OtherPlayer = _OhterUnit;
        this.HP -= _OhterUnit.AT;
    }
}

// 내려준다 상속시킨다라고 말합니다.
// C# 에서 상속이란 오직 하나만 가능하다.
// 클래스 상속을 여러개 받는 언어들도 존재하지만.(대표적 C++)
// C#은 아니다.
class Player : FightUnit
{
    int Lv = 1;

    void Heal() 
    {
        HP = 100;
        //this.
    }
}

class Monster : FightUnit
{
    int Exp = 10;
}
namespace _23Inheritance
{
    // 상속이란
    // 코드 재활용성을 향상시키기 위해서
    // (똑같은 코드 2번 치기 싫다.)
    // 어떤 계열이 있느냐를 파악하는 감.

    internal class Program
    {
        static void Main(string[] args)
        {
            // 변환이란 작업을 거치지 않으면
            // 이런일을 발생할 수 없다.
            //int Value = 500;
            //string StrValue = Value;
            //메모리 구조를 따라간다.

            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();
            // NewPlayer = NewMonster; 안된다
            // NewPlayer.Damage(10).

            // 플레이어의 부분을 모두다 포기하겠다.
            // 업캐스팅
            // 자식이 부모형이 되는것.
            // 그러므로서 자식의 능력은 버린다.
            // 다운캐스팅
            // FightUnit FU = NewPlayer;
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
