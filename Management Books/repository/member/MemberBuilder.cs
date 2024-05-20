using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.member
{
	class MemberBuilder
	{
		private string Id;
		private string Pwd;

		public MemberBuilder id(string Id)
		{
			this.Id = Id;
			return this;
		}

		public MemberBuilder pwd(string Pwd)
		{
			this.Pwd = Pwd;
			return this;
		}

		public MemberEntity build()
		{
			return new MemberEntity(Id, Pwd);
		}
	}
}
