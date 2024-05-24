using Management_Books.repository.bookCopies;
using Management_Books.repository.loan;
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

		public bool AddLoan(LoanEntity loan)
		{
			return loanRepository.Insert(loan);
		}

		private List<LoanEntity> SelectCustomerIdByLoanId(long customer_id)
		{
			return loanRepository.SelectCustomerId(customer_id);
		}

		// 2권 체크
		public bool BookBorrow(long customer_id) 
		{
			List<LoanEntity> result = SelectCustomerIdByLoanId(customer_id);
			
			
			return false;
		}

		// 반납일 체크
		public bool BookReturn(long customer_id)
		{
			List<LoanEntity> result = SelectCustomerIdByLoanId(customer_id);


			return false;
		}

		// 연장 카운트 체크 + 연장되었다면?
		public bool BookExtend(long customer_id)
		{
			List<LoanEntity> result = SelectCustomerIdByLoanId(customer_id);


			return false;
		}

		public List<LoanEntity> FindByCopyIdAll(long bookId)
		{
			return loanRepository.GetLoansByCopyIds(bookId);
		}

		private bool Block()
		{
			return false;
		}


	}
}
