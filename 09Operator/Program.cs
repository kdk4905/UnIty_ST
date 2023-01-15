using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player 
{
    int HP = 100;

    void Damage(int _HP) 
    {
        HP = _HP - 10;
    }
}

namespace _09Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Left = 3;
            int Right = 7;

            // = 대입연산자.
            // 함수에서 리턴된 값이나
            // 혹은 연산이된 값을
            // 리터럴 값일때도 있다.
            // 그 값을 받을수 있는 변수에
            // 넣어줘라.

            // 산술연산자.
            // 리턴값이라는 것은
            // 외부에 연산값이나 객체 상태값
            // 등을 끝나고 나면 외부에 반환하는 것을 말하고
            // 이런식으로 == 연산자가 있다면
            // 오른쪽부터 실행된다.
            // 연산자의 우선순위라고 하는데.
            // 산술연산자에는 */% 가 먼저되고
            // + -가 됩니다.
            Result = Left + Right; //더하기
            Result = Left - Right; //빼기
            Result = Left * Right; //곱하기
            Result = Left / Right; //나누기
            Result = Left % Right; //나머지 

            // ()연산자는 연산자의 실행순서를
            // 내가 지정해줄수 있게 된다.
            Result = (Left + Right) * 10;
            // 이런식으로
            // 산술 연산을 할수 있고.
            // 한가지 주의할점은
            // 나누기와 나머지는 0을 넣으면 안되요.
            // 10 / 0 은? 수학에서는 불가능하다.
            // 컴퓨터에는 제로디비전이라고 해서 아예 오류가 나버린다.
            // 프로그램이 실행도중 터질정도의 오류이므로
            // 주의하셔야 합니다.

            // 연산자는 함수와 비슷합니다.

            // 비교연산자가 있어요.
            // 비교연산자는 논리형으로 리턴이 되는데.
            // 논리형은 bool 이라는 녀석이 있었을 것이다.
            // 정수를 넣어줄수 있는데.
            int Number = 12312312; 

            // 100 200 상수라고 하고 정수형 상수
            // 정수로 표현되는 상수이다.
            // bool 참과 거짓이 있게 되는데
            // 참과 거짓이 상수화 된것이
            // true와 false 라는 말입니다.

            bool Bresult = true; 
            Bresult = false;

            // 이런식으로 참과 거짓을 통해서
            // 나중에 배울 조건문에서 정말 유용하게 이용되게 됩니다.
            Bresult = Left > Right; // Left가 Right보다 큰가? 참이라면 true 거짓이라면 flase를 리턴하고
            Bresult = Left < Right; // Left가 Right보다 작은가?
            Bresult = Left <= Right; // Left가 Right보다 작거나 같은가?
            Bresult = Left >= Right; // Left가 Right보다 크거나 같은가?
            Bresult = Left == Right; // Left가 Right보다 같은가?
            Bresult = Left != Right; // Left가 Right보다 다른가?

            // bool 논리 연산자
            // bool 논리 연산자는
            // 참과 거짓을 연산하는 연산자.
            // 둘다 맞다면
            // 둘다 틀리다면
            // 둘이 같다면
            Bresult = !true; // true면 false
            Bresult = !false; // false면 true

            // 둘다 true 일때만 true
            Bresult = true && false; // AND
                                     // 연속되어 있을때 그중 단 1개라도 false 면 false이다.

            // 이녀석은 하나라도 true있다면 true
            Bresult = true || false; // OR
            
            // 양쪽이 다르다면 true
            // 양쪽이 같다면 false가 되는 연산.
            Bresult = true ^ true; // XOR
            Bresult = true ^ false; // XOR
            Bresult = false ^ true; // XOR
            Bresult = false ^ false; // XOR

            // 축약 연산자.
            Result = 0; // 더하기
            // 산술 연산자를 이렇게 축약해서 사용할수가 있다.
            Result += 10;
            Result -= 10;
            Result /= 10;
            Result *= 10;
        }
    }
}
