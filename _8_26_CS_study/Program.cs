using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
자연수 n이 매개변수로 주어집니다. n을 3진법 상에서 앞뒤로 뒤집은 후, 
이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.

제한사항
n은 1 이상 100,000,000 이하인 자연수입니다.

입출력 예
n		result
45		7
125		229
*/

namespace _8_26_CS_study
{
	internal class Program
	{
		static public int solution(int n)
		{
			int answer = 0;
			int count = 0;
			List<int> list = new List<int>();
			while (n!=0)
			{
				list.Add(n%3);
				n/=3;
				count++;
			}
			list.Reverse();
			for (int i=1;i<count;i++)
			{
				answer += list[i] * (int)Math.Pow(3, i);
			}
			answer+=list[0];
			
			return answer;
		}
		static void Main(string[] args)
		{
			solution(125);
		}
	}
}
