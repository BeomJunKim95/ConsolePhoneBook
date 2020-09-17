using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
	public class PhoneBookManager// 외부에서 호출하기위해 public
	{
		const int MAX_CNT = 100;
		PhoneInfo[] infoStorage = new PhoneInfo[MAX_CNT];
		int curCnt = 0;

		//PhoneInfo phoneInfo = new PhoneInfo();

		public PhoneBookManager()
		{
			
		}
		public void ShowMenu()
		{
			Console.WriteLine("---------------------- 주소록 ------------------------");
			Console.WriteLine("1. 입력  |  2. 목록  | 3. 검색  | 4.삭제  |  5. 종료");
			Console.WriteLine("------------------------------------------------------");
			Console.Write("선택 : ");
		}

		public void InputData()
		{
			

			Console.Write("이름을 입력하세요 : ");
			name = Console.ReadLine();
			Console.Write("전화번호를 입력하세요 : ");
			phoneNumber = Console.ReadLine();

			for (curCnt = 0; curCnt < infoStorage.Length; curCnt++)
			{
				infoStorage[curCnt] = new PhoneInfo(name, phoneNumber);
				
			}
		}
		public void ListData()
		{

		}
		public void SearchData()
		{

		}
		public void DeleteData()
		{

		}
	}
}
