﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스는 왠만하면 자기의 일은 스스로하자.
// 캡슐화
class Player
{
    int AT = 10 ;
    int HP = 50 ;
    int MAXHP = 100 ;

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
        if (this.HP >= MAXHP)
        {
            Console.WriteLine("");
            Console.WriteLine("체력이 모두 회복되어있어서 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            /*this.HP*/
            HP = MAXHP;
            PrintHP();
        }
    }

    public void StatusRender() 
    {
        Console.WriteLine("---------------------------------------");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);
        // 체력 : 50/500
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("---------------------------------------");
    }
}

class Monster
{

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

        static void Town(Player _Player)
        {
            while (true)
            {
                Console.Clear() ;
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
                        //if (HP가 만피가 아니라면)
                        //{
                        //_Player.HP = _Player.MAXHP;
                        // 이 안의 내용을 채우면 됩니다.
                        // 체력 100 회복 시키기.
                        _Player.MaxHeal();
                        //} else {
                        // 경고문
                        // }
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return;

                }
            }
        }

        static void Battle()
        {
            Console.WriteLine("아직 개장하지 않았습니다.");
            Console.ReadKey();
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
            // 
            Player NewPlyaer = new Player();

            while (true)
            {
                // 함수 자체의 용도를 생각해라
                // 정말 한가지의 용도로만 사용할수 있나?
                // 
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlyaer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle();
                        break;
                }
            }

        }
    }
}
