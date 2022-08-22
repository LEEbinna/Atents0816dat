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
        public class Orc   //오크 클래스
        {
            int name = ("오크");
            int HP = 20;
            int MaxHP = 20;
            int ATT = 5;
            int DEF = 5;
        }

        public class Human    //인간 클래스
        {
            int name = ("너굴맨");
            int HP = 100;
            int MaxHP = 100;
            int ATT = 10;
            int DEF = 10;
        }

        

        static void Main(string[] args) //함수
        {
            
            Human player = new Human();
            Orc enemy = new Orc();

            public void Attack(Orc target)
            {
                int damage = Human.ATT;

                Console.WriteLine($"{name}이 {target.Name}에게 공격을 합니다.(공격력 : {damage})");
                target.TakeDamage(damage);

                Console.ReadKey();
            }
            
        }   
    }
}
