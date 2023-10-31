namespace _7th;

class Program
{
    static void Main(string[] args)
    {   
        try{
            int [] nums = {0,1,2,3};
            Console.WriteLine(nums[4]);
        }
        catch(IndexOutOfRangeException e){
            //범위를 벗어낫을 때의 오류
            // 현재는 배열을 벗어났을 때 오류이므로, 여기서는 오류가 잡히고 그 다음 catch문에서는 오류가 잡히지 않는다.
            Console.WriteLine(e.ToString());
        }
        catch(Exception e){
            //오류가 발생했을 때 실행되는 영역
            Console.WriteLine(e.ToString());
        }
        finally{
            //오류가 발생하든 아니든 무조건 실행되는 영역
            Console.WriteLine("오랫만에 새로운 언어를 배우니 재밌고 좋습니다");
        }


    }
}
