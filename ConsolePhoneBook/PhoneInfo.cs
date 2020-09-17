using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
	public class PhoneInfo //외부로 호출하기위해 클래스를 public으로 두는 습관
	{
		public string name; //필수
		public string phoneNumber; //필수
		public string birth; //선택

		public PhoneInfo() {}
		public PhoneInfo(string name, string phoneNumber)
		{
			this.name = name;
			this.phoneNumber = phoneNumber;
		}

		public PhoneInfo(string name, string phoneNumber, string birth)
		{
			this.name = name;
			this.phoneNumber = phoneNumber;
			this.birth = birth;
		}

		public void ShowPhoneInfo()
		{
			if (birth == null)
				Console.WriteLine("이름 : {0}\n번호 : {1}\n",name, phoneNumber);
			else
				Console.WriteLine("이름 : {0}\n번호 : {1}\n생일 : {2}", name, phoneNumber, birth);

		}
	}

}
