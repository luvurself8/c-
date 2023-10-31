using System.Runtime.CompilerServices;

namespace c__3;

class Program
{
    static void Main(string[] args)
    {
        // 단항연산자
        int a = 5;
        a++;
        Console.WriteLine(a);
        Console.WriteLine(-a);

        //이항연산자
        int b = 3;
        int c = 0;
        c = a-b;
        Console.WriteLine(c);

        //삼항연산자

        int d = (5>3)? 2:0;
        Console.WriteLine(d);

        // 대입연산자
        int e = a;
        Console.WriteLine(e);
        string str ="e : "+e;
        Console.WriteLine(str);

        //산술연산자
        Console.WriteLine(a+b);
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine("나누기 : " + a/b);
        Console.WriteLine("나머지 연산자 : " + a%b);

        //++ 와 -- 순서
        // 만약에 ++ 가 앞에 온다면,++ 연산을 먼저 수행하지만, 뒤에 온다면 연산을 나중에 수행한다
        a = 6;
        int g = a++;
        Console.WriteLine("a : "+ a);
        Console.WriteLine("g : "+ g);
        // g 에 a 값이 먼저 대입된 후에 a++ 가 시행된다

        // 복합대입연산자
        //x = x+2 줄여쓰기 -> x+=2
        g +=2;
        Console.WriteLine(g);

        //비교연산자
        a= 2;
        b=3;
        bool result = (a==b);
        Console.WriteLine(result);
        result = (a!=b);
        Console.WriteLine(result);
        result = (a>b);
        Console.WriteLine(result);
        result = (a<b);
        Console.WriteLine(result);
        result = (a>=b);
        Console.WriteLine(result);
        str = "준범이가 보고싶어";
        result = str.Contains("준범");
        Console.WriteLine(result);

        // 조건연산자
        Console.WriteLine((a>b)? "참입니다": "거짓입니다");
        
        //논리 연산자
        result = true;
        bool result2 = true;
        if (!result){
            Console.WriteLine("참입니다");
        }
        else{
            Console.WriteLine("거짓입니다");
        }
        if (result && result2){
            Console.WriteLine("참입니다");
        }
        else{
            Console.WriteLine("거짓입니다");
        }
        if (result|| result2){
            Console.WriteLine("참입니다");
        }
        else{
            Console.WriteLine("거짓입니다");
        }

        // 비트 연산자 : 이진수로 계산

        a = 1;
        b = 5;
        c = 0;
        Console.WriteLine(a & b);
        Console.WriteLine(a | b);
        Console.WriteLine(a ^ b);
    

    }
}
