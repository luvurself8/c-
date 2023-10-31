namespace _4th;

class Program
{
    static void Main(string[] args)
    {
        //1차원 배열
        int[] nums = {1,2,3,4,5};
        string[] vars = {"A","B","C"};
        Console.WriteLine(nums[1]);
        Console.WriteLine(vars[2]);

        //길이 구하기
        Console.WriteLine(nums.Length);

        // 마지막 요소 뽑기
        Console.WriteLine(nums[nums.Length-1]);
    
        // 2차원 배열
        int[,] doubleint = {{ 1,2,3,4 },{1,2,3,4},{1,2,3,4}};
        Console.WriteLine(doubleint[0,1]);
        Console.WriteLine(doubleint[0,3]);

        //2차원 가변배열

        int [][] ab = new int[3][];
        ab[0] = new int [4];
        ab[1] = new int [4];
        ab[2] = new int [3];
        
        ab[2][2] = 4;
        Console.WriteLine(ab[2][2]);
        Console.WriteLine("길이는 : " + ab.Length);
    
    }
}
