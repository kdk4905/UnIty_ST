﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 기본 자료형 -> 이미 있다.

//
// 사용자 정의자료형중 하나
// class 참조형 사용자 정의
// struct 값형 사용자 정의
// enum 값형 사용자 정의.

// 다른언어에서는 정수형 상수라고 하는데 c#에서는 아니다.
// 보통 어떤 상태를 표현하는것중
// 나만의 것을 가지고 싶을때 사용한다.
// 열거형이라고 불리며 사용법
// 명찰에 가까운 일이다.

enum ITEMTYPE
{
    // 내가 값의 범위를 지정한 새로운 자료형을
    // 만들어 낼수 있다는 장점이 있고
    // Switch과 궁합이 정말 좋다.
    EQUIP,
    POTION,
    QUEST,
    NONESELECT
}

// 일일이
// class PotionItem
class Item 
{
    // 아이템 타입
    public ITEMTYPE ItemType = ITEMTYPE.QUEST;

    public void PotionTypeSetting() 
    {
        ItemType = ITEMTYPE.POTION;
    }
}

namespace _22Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            NewItem.ItemType = ITEMTYPE.POTION;
            NewItem.PotionTypeSetting();

            // 값형이고.
            // int라고 생각해도 된다.
            // 사용방법 제외하고는 그냥 int라고 생각해도 된다.

            Console.WriteLine(ITEMTYPE.POTION);

            // 값형이면서 사용자 정의 자료형
            ITEMTYPE Type = ITEMTYPE.POTION;

            switch (Type)
            {
                case ITEMTYPE.EQUIP:
                    break;
                case ITEMTYPE.POTION:
                    break;
                case ITEMTYPE.QUEST:
                    break;
                case ITEMTYPE.NONESELECT:
                    break;
                default:
                    break;
            }
        }
    }
}
