namespace _6th;

class Program
{
    static void Main(string[] args)
    {
        //while 문

        int i = 0;
        while (i<6){
            //i 가 6 미만일 때, 중괄호 안이 반복해서 실행됨
            Console.WriteLine("i의 값은 : " + i);
            i++;
        }
        Console.WriteLine("빠져나갔을 때 : "+i);

        // do while 문
        // 조건을 만족하지 않아도 한번은 실행하고 , 두번째 실행부터 조건 체크
        i=5;

        do {
            Console.WriteLine("출력 "+ i);
            i++;
        }while(i<2);


        //for 
        // 몇번을 반복할 지 정확이 알고 있는 경우 while 대신 for문을 권장함

        for (i =0; i<6;i++){
            Console.WriteLine("i값 :" +i);

        }

        //for each
        // ArrayList에 저장된 모든 값을 사용하여 반복
        string[] arr = {"바나나","사과","파인애플","망고"};

        foreach(string s in arr){
            Console.WriteLine(s);
        }

        Console.WriteLine("----------------------------");
        for (i = 0; i< arr.Length; i++){
            Console.WriteLine(arr[i]);
        }
        

        // 중첩 for 문
        for (i=0; i <6; i++){

            for (int j =0; j<4; j++){
                Console.WriteLine(i+" , "+j);
            }
        }
    }
}
