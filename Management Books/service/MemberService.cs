using Management_Books.repository.member;

namespace Management_Books.service
{
	class MemberService
	{
		private MemberRepository memberRepository;

		public MemberService()
		{
			memberRepository = new MemberRepository();
		}

		/**
		 * @param	(member	: 로그인을 시도하는 입력 정보)
		 * @return	입력한 아이디 값을 기준으로, members 테이블 내에 PK 값과 일치하는 행의 데이터를
		 *			가져와서, 각각의 값을 비교한다.
		 **/
		public int Login(MemberEntity member)
		{
			MemberEntity result = memberRepository.Select(member);
			if (member.getId().Equals(result.getId()))
			{
				if (member.getPwd().Equals(result.getPwd()))
				{
					return 2;
				}
				return 1;
			}
			return 0;
		}

		public void Close()
		{
			memberRepository.AllClose();
		}
	}
}
