using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static

    // 몬스터가 100마리 죽으면
    // 뭔가를 하기로 했다.
class Monster
{
    static int MonsterDeathCount;
     
    public void Death() 
    {
        MonsterDeathCount += 1;
    }

}

class Player
{
    // 일반적인 맴버변수와 다른점
    // static을 붙이게 되면
    // 이런 경우 정적 맴버변수라고 합니다.
    // 정적 맴버변수는 일반적인 맴버변수와는 다르게
    // 객체화를 하지 않고도 사용할수 있다.
    // 그 사용법이 클래스의 이름만으로 사용할수가 있다.

    public static int PlayerCount = 0;

    
    public int AT = 10;
    public int HP = 100;

    // 클래스 내부 안에서는 사용이 가능하다.
    public void Setting(int _AT, int _HP) 
    {
        // 왜냐하면 이건 공통
        PlayerCount = 100; 

        AT = _AT;
        HP = _HP; 
    }
}

namespace _13StaticVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 플레이어를 3번 new 하게 되면
            // 플레이어가 3개 생긴것이고
            // 그 3개의 플레이어는 각각의 hp를 가지고 있다.
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;
            // 객체들을 통해서 정적 맴버변수를 사용할수는 없다.
            // 이런식으로 객체화를 전혀 하지 않고 사용할수 있는 녀석.
            // 정적 맴버변수라고 부르고
            // 이런 정적 맴버변수는 데이터 영역에 들어가게 됩니다.

            // 이 맴버변수라고 하는 녀석은
            // 각각 존재한다.

            // 어떤 클래스가 공유하고 싶은 값
            // 몬스터 클래스라면
            // 현재 존재하는 모든 몬스터의 수
            // 객체를 아무리 만들어도
            // 정적 맴버는 그 객체와의 관련성은
            // 객체 내부에서 사용할 수 있다 뿐이지
            // 객체의 개수만큼 만들어지는 것은 아니다.
            // 즉 모든 객체가 공유하는 하나의 변수가 되어준다.

            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            // 모든 객체가 값을 공유할 필요가 있는 데이터를
            // 정의하는데 사용한다.

            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();

            // public static int PlayerCount = 0;
            // 정적맴버변수라고 하는데
            // 이녀석은 객체 귀속된것이 아니라.
            // 클래스 그자체에 귀속되고
            // 데이터 영역에 메모리가 올라간다.

            // static이 붙지 않은 맴버변수들은
            // 맴버변수라고 불리며
            // 이녀석들은 객체 하나하나가
            // 자신의 것을 가진다.

            // 보통 static 맴버변수는
            // 게임내에서 하나만 존재하며
            // 일반적으로 클래스 내부에서 모든 객체가 공유하고 싶어하는
            // 변수를 만들때 사용한다.

        }
    }
}
