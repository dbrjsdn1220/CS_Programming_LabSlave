using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Management_Books.repository.loan
{
	class LoanRepository : CommonRepository
	{
		MySqlConnection conn;
		MySqlCommand cmd;
		MySqlDataReader reader;

		public LoanRepository()
		{
			conn = GetConnection(); conn.Open();
		}

		public bool InsertLoan(long copyBookId, int studentId)
		{
			string startDate = DateTime.Now.ToString("yyyy-MM-dd");
			string endDate = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");
			string queryLoans = "INSERT INTO loans(copyBook_id, student_id, start_date, end_date, extend) VALUES(@copyBook_id, @student_id, @start_date, @end_date, @extend)";

			try
			{
				cmd = GetCommand(queryLoans, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@copyBook_id", copyBookId);
				cmd.Parameters.AddWithValue("@student_id", studentId);
				cmd.Parameters.AddWithValue("@start_date", startDate);
				cmd.Parameters.AddWithValue("@end_date", endDate);
				cmd.Parameters.AddWithValue("@extend", 0);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / InsertLoan.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public bool DeleteLoan(long copyBookId)
		{
			string queryLoans = "DELETE FROM loans WHERE copyBook_id = @copyBook_id";
		
			try
			{
				cmd = GetCommand(queryLoans, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@copyBook_id", copyBookId);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / DeleteLoan.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public bool UpdateBookBorrowCount(int studentId, int nowCount)
		{
			string queryStudents = "UPDATE students SET nowCount = @nowCount WHERE student_id = @student_id";

			try
			{
				cmd = GetCommand(queryStudents, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@nowCount", nowCount + 1);
				cmd.Parameters.AddWithValue("@student_id", studentId);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / UpdateBookBorrowCount.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public bool UpdateBookReturnCount(int studentId, int nowCount)
		{
			string queryStudents = "UPDATE students SET nowCount = @nowCount WHERE student_id = @student_id";

			try
			{
				cmd = GetCommand(queryStudents, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@nowCount", nowCount - 1);
				cmd.Parameters.AddWithValue("@student_id", studentId);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / UpdateBookReturnCount.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public bool UpdateBookExtend(long copyBookId, DateTime endDate)
		{
			string end_date = endDate.AddDays(7).ToString("yyyy-MM-dd");
			string queryLoans = "UPDATE loans SET extend = @extend, end_date = @end_date WHERE copyBook_id = @copyBook_id";

			try
			{
				cmd = GetCommand(queryLoans, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@extend", 1);
				cmd.Parameters.AddWithValue("@end_date", end_date);
				cmd.Parameters.AddWithValue("@copyBook_id", copyBookId);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / UpdateBookExtend.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public List<LoanEntity> SelectCopyBookId(long copyBookId)
		{
			string queryLoans = "SELECT * FROM loans WHERE copyBook_id = @copyBook_id";

			try
			{
				cmd = GetCommand(queryLoans, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@copyBook_id", copyBookId);
				reader = cmd.ExecuteReader();
				return LoadLoanDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / SelectCopyBookId.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<LoanEntity>();
		}

		public List<LoanEntity> SelectStudentId(int studentId)
		{
			string queryLoans = "SELECT * FROM loans WHERE student_id = @student_id";

			try
			{
				cmd = GetCommand(queryLoans, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@student_id", studentId);
				reader = cmd.ExecuteReader();
				return LoadLoanDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / SelectStudentId.method / Error : " + e.Message + "]");

			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<LoanEntity>();
		}

		public Tuple<int, int> CheckBorrowCount(int studentId)
		{
			int nowCount = -1;
			int maxCount = -1;
			string queryStudents = "SELECT nowCount, maxCount FROM students WHERE student_id = @student_id";

			try
			{
				cmd = GetCommand(queryStudents, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@student_id", studentId);
				reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					nowCount = reader.GetInt32("nowCount");
					maxCount = reader.GetInt32("maxCount");
				}
				return Tuple.Create(nowCount, maxCount);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / CheckBorrowCount.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return Tuple.Create(nowCount, maxCount);
		}

		public List<LoanEntity> GetCopyBookIdByLoans(long bookId)
		{
			string queryLoans = "SELECT loans.* " +
								"FROM copy_books " +
								"INNER JOIN loans ON copy_books.copyBook_id = loans.copyBook_id " +
								"WHERE copy_books.book_id IN (@book_id)";
			try
			{
				cmd = GetCommand(queryLoans, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@book_id", bookId);
				reader = cmd.ExecuteReader();
				return LoadLoanDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / GetLoansByCopyId.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<LoanEntity>();
		}

		// ======================================================================================================

		private LoanEntity LoadLoanData(MySqlDataReader reader)
		{
			if (reader.Read())
			{
				return new LoanBuilder()
							.loanId(reader.GetInt64(0))
							.copyBookId(reader.GetInt64(1))
							.studentId(reader.GetInt32(2))
							.startDate(reader.GetDateTime(3).Date)
							.endDate(reader.GetDateTime(4).Date)
							.extend(reader.GetBoolean(5))
							.build();
			}
			return new LoanBuilder().build();
		}

		private List<LoanEntity> LoadLoanDataList(MySqlDataReader reader)
		{
			List<LoanEntity> loanList = new List<LoanEntity>();
			while (reader.Read())
			{
				loanList.Add(new LoanBuilder()
									.loanId(reader.GetInt64(0))
									.copyBookId(reader.GetInt64(1))
									.studentId(reader.GetInt32(2))
									.startDate(reader.GetDateTime(3).Date)
									.endDate(reader.GetDateTime(4).Date)
									.extend(reader.GetBoolean(5))
									.build());
			}
			return loanList;
		}

		// ======================================================================================================
		
		/**
		 * 데이터베이스 연결과 관련된 기능의 메모리 할당을 해제하는 공용 기능
		 **/

		private void ReaderClose()
		{
			try
			{
				if (reader != null)
				{
					reader.Close();
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / ReaderClose.method / Error : " + e.Message + "]");
			}
			finally
			{
				if (reader != null)
				{
					reader.Dispose();
				}
			}
		}

		private void CommandClose()
		{
			try
			{
				if (cmd != null)
				{
					cmd.Dispose();
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / CommandClose.method / Error : " + e.Message + "]");
			}
		}

		private void ConnectionClose()
		{
			try
			{
				if (conn != null)
				{
					conn.Close();
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / ConnectionClose.method / Error : " + e.Message + "]");
			}
			finally
			{
				if (conn != null)
				{
					conn.Dispose();
				}
			}
		}

		public void AllClose()
		{
			ReaderClose();
			CommandClose();
			ConnectionClose();
		}
	}
}
