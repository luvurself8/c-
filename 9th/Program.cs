using System.Runtime;

namespace _9th;

class Program
{
    static void Main(string[] args)
    {   
        // 특징 1 : 은닉화
        Car car = new();
        Car car2 = new Car();
        car.GetModel();
        car2.GetModel();

        // public이여서 바로 접근이 가능하다
        car.handle = "ABC1000";
        
        Console.WriteLine("첫번째 자동차 핸들");
        car.GetHandle();

        Console.WriteLine("두번째 자동차 핸들");
        car2.GetHandle();

        Console.WriteLine("모델바꾸기");
        // model 변수는 private라서 바로 접근이 불가능하다
        car.SetModel("AA");
        car.GetModel();

        //특징 2 상속화
        CarSon carson = new();
       
        carson.handle = "핸들32";
        carson.GetModel();
        carson.GetHandle();
        carson.GetA();

    //특징3 다형성 (override)
    Animal animal = new();

    animal.AnimalSound();

    Animal dog = new Dog();
    dog.AnimalSound();

    Animal owl = new Owl();
    owl.AnimalSound();

    Animal seagal = new Seagal();
    seagal.AnimalSound();

    }
}
