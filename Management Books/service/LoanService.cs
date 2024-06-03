using Management_Books.repository.loan;
using System;
using System.Collections.Generic;

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
					return "대출은 성공 했으나, 학생의 현재 빌린 책의 갯수, 갱신 실패";
				}
				return "대출 실패";
			}
			return "빌린 책이 2권을 초과 하였습니다.";
		}

		public string BookReturn(long copyBookId, int studentId)
		{
			(int nowCount, int maxCount) = loanRepository.CheckBorrowCount(studentId);
			
			if (nowCount > 0)
			{
				if (loanRepository.DeleteLoan(copyBookId))
				{
					if (loanRepository.UpdateBookReturnCount(studentId, nowCount))
					{
						return "반납 성공";
					}
					return "반납은 성공 했으나, 학생의 현재 빌린 책의 갯수, 갱신 실패";
				}
				return "반납 실패";
			}
			return "빌린 책이 없습니다.";
		}

		public bool BookExtend(long copyBookId, DateTime endDate)
		{
			return loanRepository.UpdateBookExtend(copyBookId, endDate);
		}

		public List<LoanEntity> SelectCopyBookIdByLoans(long copyBookId)
		{
			return loanRepository.SelectCopyBookId(copyBookId);
		}

		public List<LoanEntity> SelectStudentIdByLoans(int studentId)
		{
			return loanRepository.SelectStudentId(studentId);
		}

		/**
		 * @param	(bookId	: )
		 * @return	
		 **/
		public List<LoanEntity> FindByCopyIdAll(long bookId)
		{
			return loanRepository.GetCopyBookIdByLoans(bookId);
		}
	}
}
