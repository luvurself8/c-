namespace _9th;

class Car
{
    private string model = "PMODEL";
    public string handle = "ABCMODEL";

    //protected는 상속받은 클래스 (자식 클래스)에서만 사용 가능
    protected string a = "A";

    public void GetModel(){
        Console.WriteLine(model);
    }
    public void GetHandle(){
        Console.WriteLine(handle);
    }

    public void SetModel(string m ){
        model= m;
    }
}
