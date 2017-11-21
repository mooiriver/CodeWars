using System;
using System.Linq;

public class Kata
{
  public static int CountBits(int n)
  {
    String binaryStr = Convert.ToString(n,2);
		int count = 0;
		for(int i=0; i < binaryStr.Length; ++i)
    {
			if(binaryStr[i] == '1')
      {
				count++;
			}
		}
		return count;	
  }
}
