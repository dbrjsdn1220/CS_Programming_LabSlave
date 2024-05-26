using Management_Books.repository.book;
using Management_Books.repository.bookCopies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Books.service
{
	class BookService
	{
		private BookRepository bookRepository;

		public BookService()
		{
			bookRepository = new BookRepository();
		}

		/**
		 * @return	Books 테이블 내의 모든 데이터를 가져오기
		 **/
		public List<BookEntity> GetAllBooks()
		{
			return bookRepository.GetAllData();
		}

		/**
		 * @param	(book	: 단일 책에 대한 정보)
		 * @return	단일 책에 대한 정보를 기준으로,
		 *			조건에 따라 단일 책 데이터를 우선 추가한 후, 사본 책 데이터 추가
		 **/
		public bool AddBook(BookEntity book)
		{
			(long checkBookId, int copyCount) = bookRepository.CheckBookTitleExists(CheckLastCharSpace(book.getTitle()), book.getCopyCount());

			/**
			 * @true	: 제목과 일치하는 단일 책이 이미 존재하는 경우, 사본 책만 추가
			 * @false	: 단일 책의 상세 정보 및, 사본 책 데이터 추가
			 */
			if (checkBookId > -1L)	
			{
				return bookRepository.InsertCopyBooks(checkBookId, copyCount, (book.getCopyCount() + copyCount));
			}
			return bookRepository.InsertBookAndCopyBooks(book);
		}

		/**
		 * @param	(option	: 검색할 때, 사용할 조건 기준)
		 * @param	(value	: 검색 조건에 부합하는 문자 일부분)
		 * @return	검색하는 조건에 따라, 그것에 부합하는 단일 책 데이터 검색을 시행하여 나온 결과들을 반환한다.
		 **/
		public List<BookEntity> SearchOption(string option, string value)
		{
			switch (option)
			{
				case "제목":
					return bookRepository.SelectTitle(CheckLastCharSpace(value));
				case "저자":
					return bookRepository.SelectAuthor(CheckLastCharSpace(value));
				default:
					return new List<BookEntity>();
			}
		}

		/**
		 * @param	(bookId	: 단일 책의 PK 값)
		 * @return	Books 테이블 내에 PK 값과 일치하는 행의 데이터를 가져온다.
		 **/
		public BookEntity FindBookByBookId(long bookId)
		{
			return bookRepository.SelectBookId(bookId);
		}

		/**
		 * @param	(bookId	: 단일 책의 PK 값)
		 * @return	Copy_Books 테이블 내에 Books 테이블의 특정 행의 PK값과 일치하는
		 *			데이터들을 가져온다.
		 **/
		public List<CopyBookEntity> FindAllBookIdByCopyBook(long bookId)
		{
			return bookRepository.FindAllCopyBook(bookId);
		}

		/**
		 * @param	(copyBookId	: 빌려가고자 하는 사본 책 PK 값)
		 * @return	Copy_Books 테이블 내에 PK 값과 일치하는 행의 데이터를 수정하여,
		 *			책을 빌려갔음을 표시한다.
		 **/
		public bool BookBorrow(long copyBookId)
		{
			return bookRepository.SelectCopyBookIdByBorrow(copyBookId);
		}

		public bool BookReturn(long copyBookId)
		{
			return bookRepository.SelectCopyBookIdByReturn(copyBookId);
		}

		// ===================================================================

		/**
		 * @param	(value : 검색에 사용될 문자열 값)
		 * @return	제목 값 뒤에 빈 칸 띄어쓰기 부분을 전부 제거
		 **/
		private string CheckLastCharSpace(string value)
		{
			return value.TrimEnd(' ');
		}
	}
}
