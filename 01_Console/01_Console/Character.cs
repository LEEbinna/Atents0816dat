
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_Console
{
    
    public class Character  
    {
        protected string name;
        protected int hp = 100;
        protected int maxHP = 100;
        protected int strenth = 10;
        protected int dexterity = 5;
        protected int intellegence = 7;

        protected bool isDead = false;

        public string Name => name;
        public bool IsDead => isDead;   // 간단하게 읽기전용 프로퍼티 만드는 방법

        //Random random = new Random();
        //for (int i = 0; i < 100; i++)
        //{
        //    int randNum = random.Next();
        //    // % : 앞에 숫자를 뒤의 숫자로 나눈 나머지값을 돌려주는 연산자. (모듈레이트 연산. 나머지 연산)
        //    // 10 % 3 하면 결과는 1
        //    // % 연산의 결과는 항상 0~(뒤 숫자-1)로 나온다.
        //    Console.WriteLine($"랜덤 넘버 : {randNum}");
        //}


        // 배열 : 같은 종류(데이터타입)의 데이터를 한번에 여러개 가지는 유형의 변수
        //int[] intArray; // 인티저를 여러개 가질 수 있는 배열
        //intArray = new int[5];    // 인티저를 5개 가질 수 있도록 할당

        string[] nameArray = { "너굴맨", "개굴맨", "가", "나", "다" }; // nameArray에 기본값 설정(선언과 할당을 동시에 처리)

        protected Random rand;

        public int HP
        {
            get // 이 프로퍼티를 읽을 때 호출되는 부분. get만 만들면 읽기 전용 같은 효과가 있다.
            {
                return hp;
            }

            private set // 이 프로퍼티에 값을 넣을 때 호출되는 부분. set에 private을 붙이면 쓰는 것은 나만 가능하다.
            {
                hp = value;
                if( hp > maxHP )
                {
                    hp = maxHP;
                }
                if( hp <= 0 )
                {
                    // 사망 처리용 함수 호출
                    Dead();
                }
            }
        }

        private void Dead()
        {
            Console.WriteLine($"{name}이 사망");
            isDead = true;
        }

        public Character()
        {
            //Console.WriteLine("생성자 호출");
            rand = new Random(DateTime.Now.Millisecond);
            int randomNumber = rand.Next(); // 랜덤 클래스 이용해서 0~21억 사이의 숫자를 랜덤으로 선택
            randomNumber %= 5;  //randomNumber = randomNumber % 5;  // 랜덤으로 고른 숫자를 0~4로 변경
            name = nameArray[randomNumber]; // 0~4로 변경한 값을 인덱스로 사용하여 이름 배열에서 이름 선택

            GenerateStatus();
            TestPrintStatus();
            // 실습
            // 1. 이름이 nameArray에 들어있는 것 중 하나로 랜덤하게 선택된다.
            // 2. maxHP는 100~200 사이로 랜덤하게 선택된다.
            // 3. hp는 maxHP와 같은 값이다.
            // 4. strenth, dexterity, intellegence은 1~20 사이로 랜덤하게 정해진다.
            // 5. TestPrintStatus 함수를 이용해서 최종 상태를 출력한다.
            // 시간 : 1시 20분 -> 1시 50분
        }

        public Character(string newName)
        {
            //Console.WriteLine($"생성자 호출 - {newName}");
            rand = new Random(DateTime.Now.Millisecond);
            name = newName;

            GenerateStatus();
            TestPrintStatus();
        }

        public virtual void GenerateStatus()
        {
            maxHP = rand.Next(100, 201);    // 100에서 200 중에 랜덤으로 선택
            hp = maxHP;

            strenth = rand.Next(20) + 1;    // 1~20 사이를 랜덤하게 선택
            dexterity = rand.Next(20) + 1;
            intellegence = rand.Next(20) + 1;
        }

        //public void SetName(string newName)
        //{
        //    name = newName;
        //}

        // 맴버 함수 -> 이 클래스가 가지는 기능
        public virtual void Attack(Character target)
        {
            int damage = strenth;
            Console.WriteLine($"{name}이 {target.name}에게 공격을 합니다.(공격력 : {damage})");
            target.TakeDamage(damage);
        }

        public virtual void TakeDamage(int damage)
        {
            HP -= damage;
            Console.WriteLine($"{name}이 {damage}만큼의 피해를 입었습니다.");
        }

        public virtual void TestPrintStatus()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ 이름\t:\t{name}");
            Console.WriteLine($"┃ HP\t:\t{hp,4} / {maxHP,4}");
            Console.WriteLine($"┃ 힘\t:\t{strenth,2}");
            Console.WriteLine($"┃ 민첩\t:\t{dexterity,2}");
            Console.WriteLine($"┃ 지능\t:\t{intellegence,2}");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
