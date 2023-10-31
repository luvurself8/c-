namespace _8th;

class Program
{
    static void Main(string[] args)
    {   
        int a = 5;
        int b = 6;
        
        // 객체생성 
        Class1 class1 = new();

        // AddNumber 호출
        int result = class1.AddNumber(a,b);
        Console.WriteLine(result);

        // SoundFunction 호출
        class1.SoundFunction();

        // ReadNumber 호출
        class1.ReadNumber(a);
    }

    
}
