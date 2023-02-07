using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 코드 재활용성이 떨어진다는 표현을 사용하게 된다.
// 이 코드 재활용성을 향상시키기 위한 문법이.
// 상속이다.

// 클래스는 왠만하면 자기의 일은 스스로하자.
// 캡슐화
class FightUnit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int m_MAXHP = 100;

    public int MAXHP 
    {
        set 
        {
            m_MAXHP = value; 
        }

        get 
        {
            return m_MAXHP; 
        }
    }

    public bool IsDeath() 
    {
        // A = 100
        // 100 = A
        
        // 함수도 연산자에 가깝다.
        // 결과값이 있다.
        // bool boolDeath = HP <= 0;
        // 연산자도 함수에 가깝다고 했다.
        return HP <=0;
    }

    public void StatusRender()
    {
        Console.WriteLine(Name + "의 능력치 --------------------------");
        Console.WriteLine("공격력 : " + AT.ToString());
        // 체력 : 50/500
        Console.WriteLine("체력 : " + HP.ToString() + "/" + m_MAXHP.ToString());
        Console.WriteLine("---------------------------------------");
    }

    public void Damage(FightUnit _OhterUnit) 
    {
        Console.Write(Name);
        Console.Write("가 ");
        Console.Write(_OhterUnit.AT);
        Console.WriteLine("의 데미지를 입었습니다.");
        Console.ReadKey();
        HP -= _OhterUnit.AT;
    }
}

class Player : FightUnit
{
    public void PrintHP()
    {
        // 그 객체의 맴버변수와 관련된 코드를 2번 이상 치면
        // 함수로 만들어라.
        Console.WriteLine("");
        Console.Write("현재 플레이어의 HP 는");
        Console.Write(HP);
        Console.WriteLine("입니다.");
        Console.ReadKey();
    }

    public void MaxHeal(/*Player this*/)
    {
        // 함수는 비대하지 않을수록 좋다.
        // 10~5 짜리 함수를 
        if (this.HP >= m_MAXHP)
        {
            Console.WriteLine("");
            Console.WriteLine("체력이 모두 회복되어있어서 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            /*this.HP*/
            HP = m_MAXHP;
            PrintHP();
        }
    }

    public Player()
    {

    }

    public Player(string _Name)
    {
        Name = _Name;
    }
}

class Monster : FightUnit
{
    public Monster()
    {

    }

    // 인자값을 만들어 줄수도 있다.
    public Monster(string _Name)
    {
        Name = _Name;
    }
}

enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT,
}

// 에러나 혹은 잘못된 선택에 관한것도 만든다.
namespace TextRpg001
{
    class Test
    {

    }
    internal class Program
    {
        // 시작한다.
        // 마을로 갈지 싸움터로 갈지를 정해주는 함수.

        static STARTSELECT StartSelect()
        {
            // 분명히 있다.
            // 없을리가 없다.
            // 내가 못찾으면 내가 능력이 부족한거다
            // 나는 콘솔 화면을 모조리 지우는 함수를 찾고 싶다.

            // 프로그래머들은 대부분 이성적이고
            // 이름을 엉망
            // 
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 가시겠습니까?");

            // 리턴이란 구문은 리턴이 되는 순간
            // 함수를 완전히 종료시킨다.
            // 즉 리턴을 한번했다면 그 아래
            // 아무리 많은 코드가 있어도.
            // 소용이 없다.

            ConsoleKeyInfo CKI = Console.ReadKey();
            Console.WriteLine("");

            switch (CKI.Key)
            {

                case ConsoleKey.D1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }

        static STARTSELECT Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다. ");

                // 초반에 프로그래밍의 전부.
                // 객체(클래스)를 선언해야 할떄
                // 함수의 분기
                // 함수를 합칠때와 쪼갤때.

                // ConsoleKeyInfo CKI = Console.ReadKey();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        //if (hp가 만피가 아니라면)
                        //{
                        _Player.MaxHeal();
                        //}
                        //else
                        //{
                        // 경고문
                        //}
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return STARTSELECT.NONESELECT;

                }
            }
        }

        static STARTSELECT Battle(Player _Player)
        {
            //Console.WriteLine("아직 개장하지 않았습니다.");
            //Console.ReadKey();

            Monster NewMonster = new Monster("몬스터");

            // 객체지향
            // 객체를 지향해서 사용한다.

            // true || false;
            // _Player.IsDeath()

            while (false == NewMonster.IsDeath() && false == _Player.IsDeath())
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();

                NewMonster.Damage(_Player);
                if (false == NewMonster.IsDeath())
                {
                    _Player.Damage(NewMonster);
                }
            }
            Console.WriteLine("싸움이 결판 났습니다.");

            if (true == NewMonster.IsDeath())
            {
                Console.WriteLine("플레이어의 승리 입니다.");
            }
            else
            {
                Console.WriteLine("몬스터의 승리 입니다.");
            }

            Console.ReadKey();

            return STARTSELECT.SELECTTOWN;
        }

        static void Main(string[] args)

        {
            // 객체지향 프로그래밍이란
            // 결국. 클래스로 설계하고
            // 객체로 만들어 나가는 것.

            // 저는 마을과 싸움터로 나눠서
            // 입장하게 하고 싶다면
            // 반복문과 조건문중

            // 첫번째 static
            Player NewPlayer = new Player("플레이어");

            //NewPlayer.MAXHP

            STARTSELECT SelectCheck = STARTSELECT.NONESELECT;

            while (true)
            {
                // 함수 자체의 용도를 생각해라
                // 정말 한가지의 용도로만 사용할수 있나?

                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = Battle(NewPlayer);
                        break;
                }
            }

        }
    }
}
