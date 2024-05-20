using Management_Books.repository.member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.service
{
	class MemberService
	{
		private MemberRepository memberRepository;

		public MemberService()
		{
			memberRepository = new MemberRepository();
		}

		public int Login(MemberEntity member)
		{
			MemberEntity result = memberRepository.Select(member);
			if (member.getId().Equals(result.getId()))
			{
				if (member.getPwd().Equals(result.getPwd()))
				{
					memberRepository.AllClose();
					return 2;
				}
				return 1;
			}
			return 0;
		}
	}
}
