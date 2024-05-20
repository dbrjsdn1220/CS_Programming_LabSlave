using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.member
{
	class MemberEntity
	{
		private string id;
		private string pwd;

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
	}
}
