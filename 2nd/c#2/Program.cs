namespace c_2;

class Program
{
    static void Main(string[] args)
    {
        int num1 = -5;
        int num2 = 5;
        Console.WriteLine(num1+num2);

        long bignum = 100000L;
        Console.WriteLine(bignum);

        short smallnum1 = 500;
        byte smallnum2 = 2;
        Console.WriteLine(smallnum1);
        Console.WriteLine(smallnum2);

        bool logic =true;
        Console.WriteLine(logic);
        //코드를 분기하고자 할 때 많이 사용

        float flt = 0.5F;
        double doublenum = 0.44D;

        Console.WriteLine(flt);
        Console.WriteLine(doublenum);


        string str1 = "abc";
        char str2 = 'a';
        Console.WriteLine(str1);
        Console.WriteLine(str2);
        
        int a = 5;
        int b = 6;
        a = b;
        Console.WriteLine(b);
        // 형변환
        // string type에 int type 넣기
        string c ="";
        c= a.ToString();
        Console.WriteLine(c);

        // int type에 string타입 넣기
        int num = Int32.Parse(c);
        Console.WriteLine(num);

    }
}
