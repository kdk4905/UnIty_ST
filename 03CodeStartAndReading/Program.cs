using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//코드는 위에서 아래로
//오른쪽에서 왼쪽으로 읽는다.

namespace _03CodeStartAndReading
{
    internal class Program
    {
        // 코드가 실행된다고 함은
        // 어디서부턴가
        // 한줄한줄씩 os(운영체제)가 내 프로그램을
        // 읽어주는 것이다.
        // Window
        // 리눅스
        // 안드로이드

        // 쪼개서 읽지 말아라.
        // static void Main(string[] args)이 있으면 여기서부터 읽는다.
        // {
        // 이 사이의 내용을 읽는다.
        // }
        static void Main(string[] args)
        {
            // 한줄한줄 읽는다는 것이 좀 힘든 일이지만
            // 그걸 ide가 도와준다.
            // 디버깅중 코드 한줄씩 실행. 디버깅 - 문제해결 능력
            // 디버깅
            // 문제를 한번에 해결하려고 하면 안된다.
            // 암산으로 해결하려고 하면 안된다.
            // 문제를 해결할 때는 고민하지 않는다. 보면서 한다
            // f10을 누르면 된다.
                // f10을 눌르면 static void Main(string[] args) 바로 밑에부터 시작이 된다.
 
            //의마가 있는 코드
            Console.WriteLine("하하");
                // 한번 더 누르면 여기로 오게되고
                // 아직 읽기 전이다.
            Console.WriteLine("호호");
        }
    }
}
