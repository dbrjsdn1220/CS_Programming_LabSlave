using Management_Books.repository.bookCopies;
using Management_Books.repository.loan;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.service
{
	class LoanService
	{
		private LoanRepository loanRepository;

		public LoanService()
		{
			this.loanRepository = new LoanRepository();
		}

		public string BookBorrow(long copyBookId, int studentId) 
		{
			(int nowCount, int maxCount) = loanRepository.CheckBorrowCount(studentId);

			if (nowCount < maxCount)
			{
				if (loanRepository.InsertLoan(copyBookId, studentId))
				{
					if (loanRepository.UpdateBookBorrowCount(studentId, nowCount))
					{
						return "대출 성공";
					}
					return "현재 빌린 책의 갯수, 갱신 실패";
				}
				return "대출 실패";
			}
			return "대출 불가능";
		}

		public List<LoanEntity> SelectCopyBookIdByLoans(long copyBookId)
		{
			return loanRepository.SelectCopyBookId(copyBookId);
		}

		public List<LoanEntity> SelectStudentIdByLoans(int studentId)
		{
			return loanRepository.SelectStudentId(studentId);
		}




		/*// 반납일 체크
		public bool BookReturn(long customer_id)
		{
			List<LoanEntity> result = SelectStudentIdByLoans(customer_id);


			return false;
		}

		// 연장 카운트 체크 + 연장되었다면?
		public bool BookExtend(long customer_id)
		{
			List<LoanEntity> result = SelectStudentIdByLoans(customer_id);


			return false;
		}*/

		public List<LoanEntity> FindByCopyIdAll(long bookId)
		{
			return loanRepository.GetLoansByCopyId(bookId);
		}

		private bool Block()
		{
			return false;
		}


	}
}
