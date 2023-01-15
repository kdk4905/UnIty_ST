using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18for
{
    internal class Program
    {
        // 자기가 본적이 없는 형태의
        // 코드나 구조를 보면
        // 거부반응부터 일으키는 경우가 있는데
        // 당연히란 없다.
        // 함수의 인자값은 메모리화 되고 값이 변할수 있어야 하는데
        // while문은 반환하거나 저장하는 기능을 내포하는
        // 키워드가 아니다.
        // void Func(while(true))
        // {
        // }
        static void Main(string[] args)
        { //
            // 반복문 3가지를 다 설명했ㅅ브니다.
            // while
            // do while
            // for

            // 함수의 중괄호 내부에서만
            // 함수안에서만 사용할 수 있다.
            // 함수밖에서는 사용할 수 없다.

            // for (초기화문; 조건문; 증감문)
            //  {
            //      실행코드
            //  }
            // for문 필요없다.
            // for문의 장점은 접근성.
            // 그걸 하나의 for라는 키워드로 초기화와 조건, 증감

            // 한방에 변수를 선언후 초기화하고
            // 그걸로 조건을 비교하고
            // 그 변수를 변화시키는 코드를 한줄에 다 담았다.

            // 초기화문
            // 조건문
            // 실행코드
            // 증감문
            // 조건문
            // 실행코드
            // 증감문...

            // 변수 하나와 연산자만 있으면
            // 실행되는 연산자를 단항 연산자라고 하는데
            // 정수형일때 ++을 하게 되면
            // 1증가 하고
            // --를 하게 되면
            // 1감소하게 된다.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int y = 0;
            for (; y < 10; y++)
            {
                Console.WriteLine(y);
            }

            // 이제 while문 입니다.
            for (; true; )
            {
                Console.WriteLine(100);
            }

        }
    }
}
