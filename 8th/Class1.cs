
namespace _8th;

class Class1
{
    // internal void AddNumber(int v1, int v2)
    // {
    //     throw new NotImplementedException();
    // }

    public int AddNumber(int a, int b){
        return a+b;
    }

    public void SoundFunction(){
        Console.WriteLine("소리를 냅니다");
    }

    public void ReadNumber(int a){
        Console.WriteLine("숫자를 출력해주는 함수입니다 " + a);
    }

}
