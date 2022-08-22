using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01_Console
{
    internal class Program
    {
        public class Orc   //오크 설계 
        {
            int HP = 20;
            int MaxHP = 20;
            int ATT = 5;
            int DEF = 5;
        }

        public class Human    //인간 설계
        {
            int HP = 100;
            int MaxHP = 100;
            int ATT = 10;
            int DEF = 10;
        }

        

        static void Main(string[] args) //함수
        {
            // 주말과제용
            Human player = new Human();
            Orc enemy = new Orc();

            public void Attack(Character01 target)
            {
                int damage = ;

                //rand.NextDouble();  // 0.0 ~ 1.0
                if (rand.NextDouble() < 0.3f)   // 이 조건이 참이면 30% 안쪽으로 들어왔다.
                {
                    damage *= 2;    // damage = damage * 2;
                    Console.WriteLine("크리티컬 히트!");
                }

                Console.WriteLine($"{name}이 {target.Name}에게 공격을 합니다.(공격력 : {damage})");
                target.TakeDamage(damage);
            }
            Console.ReadKey();
        }   
    }
}
