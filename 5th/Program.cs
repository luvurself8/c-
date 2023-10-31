namespace _5th;

class Program
{
    static void Main(string[] args)
    {
        int a =2;
      
        // if else
        if (a<1){
            // if문이 참일 때 실행됨
            Console.WriteLine("if 문 실행");

        }
        else if(a<3){
            
            Console.WriteLine("if else 문 실행");

        }
        else{
            Console.WriteLine("else 문 실행");
        }

        // 삼항연산자
        string result = (a<=3)? "참입니다": "거짓입니다";
        Console.WriteLine(result);

        //switch 조건문
        int week = 3;
        switch(week){
            case 1:
                Console.WriteLine("월요일");
                break;
            case 2:
                Console.WriteLine("화요일");
                break;
            case 3:
                Console.WriteLine("수요일");
                break;
            case 4:
                Console.WriteLine("목요일");
                break;
            case 5:
                Console.WriteLine("금요일");
                break;
            case 6:
                Console.WriteLine("토요일");
                break;
            case 7:
                Console.WriteLine("일요일");
                break;
            default:
                Console.WriteLine("선택된것이 없다");
                break;
        }
    }
}
