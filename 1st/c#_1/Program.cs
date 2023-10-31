namespace c__1;
// 네임 스페이스 : 공간 선언을 통해 중복되는 이름을 피할 수 있음


// class는 하나의 객체를 표현한다
class Car{
    private string handle = "AMODEL";

    public void CarRun(){
        Console.WriteLine("자동차를 움직인다");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // 프로그램을 시작하면 바로 실행하는 부분
        Console.WriteLine("Hello, World!");
        // using이 있기 때문에, System.Console.WriteLine을 다 쓰지 않아도 된다
        Console.WriteLine("happy bd");
        System.Console.WriteLine("happy bd");
        // ctrl + s -> 저장
        // ctrl + shift + b -> 빌드
        // ctrl + f5 -> 실행
        
        Car car = new ();
        car.CarRun();


    }

}
