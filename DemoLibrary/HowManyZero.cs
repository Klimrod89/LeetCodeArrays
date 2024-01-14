

namespace DemoLibrary;

public class HowManyZero
{
    /*
    Input: arr = [1,0,2,3,0,4,5,0]
    Output: [1,0,0,2,3,0,0,4]
    */
    public void DuplicateZeros(int[] arr)
    {
        int numberOfZero = Array.FindAll(arr, x => x == 0).Length;
        int[] temp = new int[arr.Length + numberOfZero];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                temp[j++] = 0;
                temp[j++] = 0;
            }
            else
            {
                temp[j++] = arr[i];
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = temp[i];
        }
    }
}
