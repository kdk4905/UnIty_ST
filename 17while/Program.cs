using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비쥬얼 스튜디오를 왜쓰냐?
            // 편하려고
            // 덜치려고
            // 빠르게 사용하려고.

            // 어떤 함수내에서
            // bool 값이 들어가면 된다.
            // while (참/거짓)
            bool Check = true;
            // 조건문 -> 실행코드 -> 조건문 -> 실행코드...
            // 실행코드
            // 조건문(true) -> 실행코드 -> 조건문(false) 빠져나왔다.
            while (Check)
            {
                Console.WriteLine("무한 출력");
                Check = false;
            }

            // 실행코드 -> 조건문
            // while문은 쓸때
            // 항상 빠져나올수 있는
            // 일반적인 프로그램에서는
            // 조건을 넣어놓고 실행해줘야 한다.
            Check = false;

            // 상수를 넣어주면
            int Count = 0;
            do
            {
                Count = Count + 1;
                Console.WriteLine("무한 출력");
            } while (Count < 100);

            Count = 0;
            while (Count <= 100)
            {
                Console.WriteLine("무한 출력");
                Count = Count + 1;
            }
        }
    }
}