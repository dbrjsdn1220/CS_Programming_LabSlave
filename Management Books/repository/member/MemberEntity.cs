using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.member
{
	internal class MemberEntity
	{
		private string id { get; }
		private string pwd { get; }
		
		public MemberEntity(string id, string pwd)
		{
			this.id = id;
			this.pwd = pwd;
		}

		public string getId()
		{
			return id;
		}

		public string getPwd()
		{
			return pwd;
		}

		public string toString()
		{
			return "[id : " + id + ", pwd : " + pwd + "]";
		}
	}
}
