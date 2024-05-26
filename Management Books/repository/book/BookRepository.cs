using Management_Books.repository.bookCopies;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Management_Books.repository.book
{
	class BookRepository : CommonRepository
	{
		private MySqlConnection conn;
		private MySqlCommand cmd;
		private MySqlDataReader reader;

		public BookRepository()
		{
			conn = GetConnection(); conn.Open();
		}

		/**
		 * @param	(book	: 단일 책에 대한 정보)
		 * @return	단일 책에 대한 정보를 먼저 Books 테이블에 삽입 후,
		 *			단일 책에 대한 정보를 지닌 사본 책들의 정보를 Copy_Books 테이블에 삽입했는 지,
		 *			결과 여부(true, false)를 반환
		 **/
		public bool InsertBookAndCopyBooks(BookEntity book)
		{
			long bookId;
			string BuyDate = DateTime.Now.ToString("yyyy-MM-dd");
			string queryBooks = "INSERT INTO books(title, author, category, copy_count) VALUES(@title, @author, @category, @copy_count)";
			string queryCopyBooks = "INSERT INTO copy_books(copyBook_id, book_id, alive, buyDate) VALUES(@copyBook_id, @book_id, @alive, @buyDate)";

			try
			{
				// Books 데이터 저장
				cmd = GetCommand(queryBooks, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title", book.getTitle());
				cmd.Parameters.AddWithValue("@author", book.getAuthor());
				cmd.Parameters.AddWithValue("@category", book.getCategory());
				cmd.Parameters.AddWithValue("@copy_count", book.getCopyCount());
				cmd.ExecuteNonQuery();
				bookId = cmd.LastInsertedId;

				// Copy_Books 데이터 저장
				cmd = GetCommand(queryCopyBooks, conn);
				for (int n = 1; n <= book.getCopyCount(); n++)
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@copyBook_id", (bookId * 1000) + n);
					cmd.Parameters.AddWithValue("@book_id", bookId);
					cmd.Parameters.AddWithValue("@alive", true);
					cmd.Parameters.AddWithValue("@buyDate", BuyDate);
					cmd.ExecuteNonQuery();
				}
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / InsertBookAndCopyBooks.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		/**
		 * @param	(bookId	: 단일 책 PK값 정보)
		 * @param	(start	: 사본 책의 마지막 PK값 이어서 쓰기)
		 * @param	(end	: 사본 책의 PK값 종료 시점)
		 * @return	단일 책에 대한 정보를 지닌 사본 책들의 정보를 Copy_Books 테이블에 삽입했는 지,
		 *			결과 여부(true, false)를 반환
		 **/
		public bool InsertCopyBooks(long bookId, int start, int end)
		{
			string BuyDate = DateTime.Now.ToString("yyyy-MM-dd");
			string queryCopyBooks = "INSERT INTO copy_books(copyBook_id, book_id, alive, buyDate) VALUES(@copyBook_id, @book_id, @alive, @buyDate)";

			try
			{
				cmd = GetCommand(queryCopyBooks, conn);
				for (int n = start + 1; n <= end; n++)
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@copyBook_id", (bookId * 1000) + n);
					cmd.Parameters.AddWithValue("@book_id", bookId);
					cmd.Parameters.AddWithValue("@alive", true);
					cmd.Parameters.AddWithValue("@buyDate", BuyDate);
					cmd.ExecuteNonQuery();
				}
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / InsertCopyBooks.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		/**
		 * @param	(bookId	: 단일 책 PK값 정보)
		 * @return	단일 책 PK와 일치하는, 단일 책의 정보를 가져오기
		 **/
		public BookEntity SelectBookId(long bookId)
		{
			string queryBooks = "SELECT * FROM books WHERE book_id = @book_id";

			try
			{
				cmd = GetCommand(queryBooks, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@book_id", bookId);
				reader = cmd.ExecuteReader();
				return LoadBookData(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectBookId.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new BookBuilder().build();
		}

		/**
		 * @param	(title	: 검색할 책 제목의 문자 일부분)
		 * @return	책 제목의 문자 일부분과 부분적으로 일치하는 단일 책의 정보들을 전부 가져오기
		 **/
		public List<BookEntity> SelectTitle(string title)
		{
			string queryBooks = "SELECT * FROM books WHERE title LIKE @title";

			try
			{
				cmd = GetCommand(queryBooks, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title", "%" + title + "%");
				reader = cmd.ExecuteReader();
				return LoadBookDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectTitle.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<BookEntity>();
		}

		/**
		 * @param	(author	: 검색할 책 작성자의 문자 일부분)
		 * @return	책 작성자의 문자 일부분과 부분적으로 일치하는 단일 책의 정보들을 전부 가져오기
		 **/
		public List<BookEntity> SelectAuthor(string author)
		{
			string queryBooks = "SELECT * FROM books WHERE author LIKE @author";

			try
			{
				cmd = GetCommand(queryBooks, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@author", "%" + author + "%");
				reader = cmd.ExecuteReader();
				return LoadBookDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectAuthor.method / Error : " + e.Message + "]");
			} finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<BookEntity>();
		}

		/**
		 * @return	데이터베이스 Books 테이블 내의 모든 데이터를 가져오기
		 **/
		public List<BookEntity> GetAllData()
		{
			string queryBooks = "SELECT * FROM books";

			try
			{
				cmd = GetCommand(queryBooks, conn);
				cmd.Parameters.Clear();
				reader = cmd.ExecuteReader();
				return LoadBookDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / GetAllData.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<BookEntity>();
		}

		/**
		 * @param	(bookId	: 단일 책 PK값 정보)
		 * @return	단일 책 PK와 일치하는 동시에, 도서관에 존재하는 사본 책들의 정보를 Copy_Books 테이블에서 가져오기
		 **/
		public List<CopyBookEntity> FindAllCopyBook(long bookId)
		{
			string queryCopyBooks = "SELECT * FROM copy_books WHERE book_id = @book_id AND alive = 1";

			try
			{
				cmd = GetCommand(queryCopyBooks, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@book_id", bookId);
				reader = cmd.ExecuteReader();
				return LoadCopyBookDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / FindAllCopyBook.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<CopyBookEntity>();
		}

		/**
		 * @param	(title		: 단일 책의 제목)
		 * @param	(countPlus	: 추가되는 사본 책의 갯수)
		 * @return	Books 테이블 내에 제목과 완전히 일치하는 행의 copy_count 값을 갱신해준 후에,
		 *			[first : 단일 책 PK / second : 추가되는 책의 갯수]를 반환하고
		 *			
		 *			만일 단일 책 데이터가 존재하지 않는다면, [-1, -1]을 반환하여, 데이터가 없음을 알린다.
		 **/
		public Tuple<long, int> CheckBookTitleExists(string title, int countPlus)
		{
			long bookId = -1;
			int copyCount = -1;
			string selectQeury = "SELECT book_id, copy_count FROM books WHERE title = @title LIMIT 1";
			string updateQuery = "UPDATE books SET copy_count = @copy_count WHERE book_id = @book_id";

			try
			{
				// Books 테이블 내에 제목과 완전히 일치하는 행의 데이터 값 일부를 가져오기
				cmd = GetCommand(selectQeury, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title", title);
				reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					bookId = reader.GetInt64("book_id");
					copyCount = reader.GetInt32("copy_count");
					ReaderClose();
				}

				// Books 테이블의 PK값과 일치하는 행의 copy_count 값을 갱신
				cmd = GetCommand(updateQuery, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@copy_count", copyCount + countPlus);
				cmd.Parameters.AddWithValue("@book_id", bookId);
				cmd.ExecuteNonQuery();

				return Tuple.Create(bookId, copyCount);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / CheckBookTitleExists.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return Tuple.Create(bookId, copyCount);
		}

		/**
		 * @param	(copyBookId : 상호 작용할, 사본 책 PK 값)
		 * @return	Copy_Books 테이블 내에 PK 값과 일치하는 행의 데이터를 수정하여,
		 *			책을 빌려갔음을 표시한다.
		 **/
		public bool SelectCopyBookIdByBorrow(long copyBookId)
		{
			string queryCopyBooks = "UPDATE copy_books SET alive = @alive WHERE copyBook_id = @copyBook_id";

			try
			{
				cmd = GetCommand(queryCopyBooks, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@alive", 0);
				cmd.Parameters.AddWithValue("copyBook_id", copyBookId);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectCopyBookIdByBorrow.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		/**
		 * @param	(copyBookId : 상호 작용할, 사본 책 PK 값)
		 * @return	Copy_Books 테이블 내에 PK 값과 일치하는 행의 데이터를 수정하여,
		 *			책을 반납했음을 표시한다.
		 **/
		public bool SelectCopyBookIdByReturn(long copyBookId) {
			string queryCopyBooks = "UPDATE copy_books SET alive = @alive WHERE copyBook_id = @copyBook_id";

			try
			{
				cmd = GetCommand(queryCopyBooks, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@alive", 1);
				cmd.Parameters.AddWithValue("copyBook_id", copyBookId);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectCopyBookIdByReturn.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		// ======================================================================================================

		/**
		 * @param	(reader	: 데이터베이스 Books 테이블과 상호작용하여 나온 결과물)
		 * @return	데이터베이스와 상호작용하여 나온 단일 결과물을 객체 양식에 맞게끔 변환 해주는 공용 method
		 **/
		private BookEntity LoadBookData(MySqlDataReader reader)
		{
			if (reader.Read())
			{
				return new BookBuilder()
							.bookId(reader.GetInt64(0))
							.title(reader.GetString(1))
							.author(reader.GetString(2))
							.category(reader.GetString(3))
							.copyCount(reader.GetInt32(4))
							.build();
			}
			return new BookBuilder().build();
		}

		/**
		 * @param	(reader	: 데이터베이스 Books 테이블과 상호작용하여 나온 결과물)
		 * @return	데이터베이스와 상호작용하여 나온 다중 결과물을 객체 양식에 맞게끔 변환 해주는 공용 method
		 **/
		private List<BookEntity> LoadBookDataList(MySqlDataReader reader)
		{
			List<BookEntity> bookList = new List<BookEntity>();
			while (reader.Read())
			{
				bookList.Add(new BookBuilder()
									.bookId(reader.GetInt64(0))
									.title(reader.GetString(1))
									.author(reader.GetString(2))
									.category(reader.GetString(3))
									.copyCount(reader.GetInt32(4))
									.build());
			}
			return bookList;
		}

		/**
		 * @param	(reader	: 데이터베이스 CopyBooks 테이블과 상호작용하여 나온 결과물)
		 * @return	데이터베이스와 상호작용하여 나온 단일 결과물을 객체 양식에 맞게끔 변환 해주는 공용 method
		 **/
		private CopyBookEntity LoadCopyBookData(MySqlDataReader reader)
		{
			if (reader.Read())
			{
				return new CopyBookBuilder()
							.copyBookId(reader.GetInt64(0))
							.bookId(reader.GetInt64(1))
							.alive(reader.GetBoolean(2))
							.buyDate(reader.GetDateTime(3).Date)
							.build();
			}
			return new CopyBookBuilder().build();
		}

		/**
		 * @param	(reader	: 데이터베이스 CopyBooks 테이블과 상호작용하여 나온 결과물)
		 * @return	데이터베이스와 상호작용하여 나온 다중 결과물을 객체 양식에 맞게끔 변환 해주는 공용 method
		 **/
		private List<CopyBookEntity> LoadCopyBookDataList(MySqlDataReader reader)
		{
			List<CopyBookEntity> copyBookList = new List<CopyBookEntity>();
			while (reader.Read())
			{
				copyBookList.Add(new CopyBookBuilder()
										.copyBookId(reader.GetInt64(0))
										.bookId(reader.GetInt64(1))
										.alive(reader.GetBoolean(2))
										.buyDate(reader.GetDateTime(3).Date)
										.build());
			}
			return copyBookList;
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
				Console.WriteLine("[BookRepository.cs / ReaderClose.method / Error : " + e.Message + "]");
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
				Console.WriteLine("[BookRepository.cs / CommandClose.method / Error : " + e.Message + "]");
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
				Console.WriteLine("[BookRepository.cs / ConnectionClose.method / Error : " + e.Message + "]");
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
