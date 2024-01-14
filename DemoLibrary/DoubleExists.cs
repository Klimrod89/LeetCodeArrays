using System.Collections;

namespace DemoLibrary;

public class DoubleExists
{
	public bool CheckIfExists(int[] arr)
	{
		bool output = false;

		for(int i = 0; i < arr.Length - 1; i++)
		{
			for(int j = i+1; j < arr.Length; j++)
			{
				if((arr[i] == 2 * arr[j]) || (arr[i] * 2 ==  arr[j]))
				{
					output = true;
					return output;
				}
			}
		}
		return output;
	}
}