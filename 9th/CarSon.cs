namespace _9th;

class CarSon : Car
{
    //상속이 이루어짐
    //부모로부터 물려받은 것들을 사용할 수 있음


    // 부모에 protected로 선언된 것
    public void GetA(){
        Console.WriteLine(a);
    }
}
