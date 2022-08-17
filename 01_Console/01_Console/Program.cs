using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  //  Hello World!를 출력하는 코드
<<<<<<< Updated upstream
=======
            Console.WriteLine("이빛나");   //출력
            string str = Console.ReadLine();    // 키보드 입력을 받아서 str이라는 string 변수에 저장한다

            
                변수 : 변하는 숫자. 컴에 사용할 데이터를 저장할 수 있는 곳. 
                변수의 종류 : 데이터타입 (Data type)
                컴은 a, 1, 1.1를 모두 입력된 숫자로 인식한다 
                //int : 인티저. 정수 소수점 없는 숫자 32bit
                //float : 플로트. 실수. 소수점 있는 숫자 32bit
                //string : 스트링. 문자열. 글자들을 저장 
                //bool : 불/불리언. true,false를 저장
            */

            /*
            int a = 10; //a라는 인티저 변수에 10이라는 데이터를 넣는다.
          //int a = 5000000000; //50억은 int에 넣을 수 없다 => int는 32비트고 표현가능한 숫자는 2^32(약42억)
            long b = 5000000000; //
            int c = -100; //음수 가능
            int d = 2000000000; //가능한 최대크기
            //int e = 2.2; //소수점 불가
            int e = 2000000000;
            int f = d + e;
            //Console.WriteLine(f);

            float aa = 0.000123f; //플롯는 소수점 가능
            float ab = 0.999999999999f; //계산값이 1로 오차범위가 있음.
            float ac = 0.000000000001f;
            float ad = ab + ac; //1로 나와야하는데 1이 아닐수도 있다.
            // 플롯의 단점 : 태생적으로 오차가 있을 수 밖에 없다. 
            Console.WriteLine(ad);

            string str1 = "Hello";
            string str2 = "안녕";
            string str3 = $"Hello {a}"; //"hello 10"
            Console.WriteLine(str3);
            string str4 = str1 + str2; //"Hello 안녕!"
            Console.WriteLine(str4);

            bool b1 = true;
            bool b2 = false;

            int level = 1;
            int hp = 10;
            float exp = 0.9f; //90%
            string name = "너굴맨";
            //너굴맨의 렙1,hp10, 이름 너굴맨

            string str5 = $"{name}의 레벨은{level}이고 HP는{hp}이고 exp는{exp}다.";
            Console.WriteLine(str5);

            Console.WriteLine($"이름 : {name} 레벨 : {level} \n HP : {hp} \n exp : {exp}\n\n");


            Console.Write("이름을 입력하세요 : ");
            name = Console.ReadLine();
            Console.Write($"{name}의 레벨을 입력하세요 : ");
            //level = Console.ReadLine();
            string temp = Console.ReadLine();
            //level = int.Parse(temp);    //string을 int로 변경해주는 코드(숫자로 바꿀 수 있을 때만 가능)
            //level = Convert.ToInt32(temp); // string을 int로 변경해주는 코드. 더 세세하게 변경가능
            int.TryParse(temp, out level); // string을 int로 변경해주는 코드(숫자로 바꿀 수 없으면 0으로 만든다)
            str5 = $"{name}의 레벨은 {level}이고 HP는 {hp}고 exp는 {exp}다. \n";
            Console.WriteLine(str5);

            exp = 0.959595f;
            //너굴맨의 렙1,hp10, exp 90%

            str5 = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp * 100:F3}%다. \n";
            //exp*100을 소수점 3자리까지 찍는 코드
            */


            //이름, 레벨, hp, 경험치를 각각 입력받고 출력하는 코드 만들기
            //int level = 1;
            //int hp = 10;
            //float exp = 0.9f; //90%
            //string name = "농심너구리";

            //Console.Write($"이름 : {name} \n HP : {hp} \n exp : {exp}");

            // 변수끝 -----------------------------------------------------------------------------------------------

            //조건문(Control statement)-----------------------------------------------------------------------
            //실행되는 코드 라인을 변경할 수 있는 코드
            int level = 1;
            int hp = 10;
            float exp = 0.9f; //90%
            string name = "너굴맨";

            hp = 10;
            if (hp < 3) //hp가 2이기 때문에 참. 코드 실행
            {
                Console.WriteLine("죽기 직전입니다"); //(hp<3) 실행 코드
            }
            else if (hp < 10)
            {
                Console.WriteLine("HP가 안정적입니다");   //(hp<10) 실행 코드
            }
            else
            {
                Console.WriteLine("HP가 전부 찼습니다."); // 위 조건문들이 모두 거짓일때 실행 코드
            }

            switch (hp)
            {
                case 0: //hp가 0일때
                    Console.WriteLine("HP가 0입니다");
                    break;
                case 5: //hp가 5일때
                    Console.WriteLine("HP가 5입니다");
                    break;
                default:    //나머지
                    Console.WriteLine("HP가 0과 5가 아닙니다");
                    break;
            }

           

            string temp = Console.ReadLine();

            //실습 : exp의 값과 추가로 입력받은 경험치의 합이 1이상이면 "레벨업"이라고 출력하고 1미만이면 합계를 출력하는 코드

            //exp = 0.5f;
            //Console.WriteLine("경험치를 추가합니다");
            //Console.Write("추가할 경험치 : ");
            //string temp = Console.ReadLine();

            //float tempExp;
            //float.TryParse(temp, out tempExp);
            //if((exp + tempexp)> 1.0f)
            //{
            //    Console.WriteLine("레벨업!");
            //}
            //else
            //{
            //    Console.WriteLine($"현재 경험치 : {exp+tempExp}");
            //}

            //조건문 끝=-=========================================================================================

            //반복문

            level = 1;
            while (level < 3)   //참이면 코드 실행
            {
                Console.WriteLine($"현재 레벨 : {level}");
                level++; // level = level + 1; //level += 1;   //셋 다 같은 코드
                //level += 2; //level에 2를 더해라
            } //3보다 작을때까지 실행하다가 3보다 작지 않으면 종료

            //i는 0에서 시작해서 3보다 작으면 계속 {}코드를 시행
            hp = 10;

            for (int i=0; i<3; i++)  
            {
                Console.WriteLine($"현재 HP : {hp}");
                hp += 10;
            }
            Console.WriteLine($"최종 HP : {hp}");

            do
            {
                Console.WriteLine($"현재 경험치 : {exp + tempExp}");
                Console.WriteLine($"현재 레벨 : {level}");

                if (level == 2)    // 1+1 == 2  ...............  ==은 양쪽이 같다라는 의미
                {
                    break;
                }

                level++;
            }
            while (level < 10);
            Console.WriteLine($"최종 Level : {level}");

            //실습 : 렙업 할때까지 계속 추가 경험치를 입력하도록 하는 코드를 작성

            exp = 0.0f;
            Console.WriteLine("경험치를 추가합니다");


            Console.Write("추가할 경험치 :  ");
            string temp = Console.ReadLine();
            while (exp < 1f) ;
            {
                exp += 0.1f;
            }
            



>>>>>>> Stashed changes
            Console.ReadKey();                  // 키 입력 대기하는 코드
            
        }
    }
}
