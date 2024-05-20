using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.member
{
	internal class MemberBuilder
	{
		private string Id;
		private string Pwd;

		public MemberBuilder id(string id)
		{
			this.Id = id;
			return this;
		}

		public MemberBuilder pwd(string pwd)
		{
			this.Pwd = pwd;
			return this;
		}

		public MemberEntity build()
		{
			return new MemberEntity(Id, Pwd);
		}
	}
}
