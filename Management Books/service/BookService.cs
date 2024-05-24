using Management_Books.repository.book;
using Management_Books.repository.bookCopies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.service
{
	class BookService
	{
		private BookRepository bookRepository;

		public BookService()
		{
			bookRepository = new BookRepository();
		}

		public List<BookEntity> GetAllBooks()
		{
			return bookRepository.GetAllData();
		}

		public bool AddBook(BookEntity book)
		{
			Tuple<long, int> pair = bookRepository.CheckBookTitleExists(CheckLastCharSpace(book.getTitle()), book.getCopyCount());
			long checkBookDuplicate = pair.Item1;
			int copyCount = pair.Item2;
			/**
			 * @true : 책이 이미 존재하는 경우, 카피본만 추가
			 * @false : 책의 정보 및, 카피본 동시에 추가
			 */
			if (checkBookDuplicate > -1L)	
			{
				return bookRepository.InsertCopies(checkBookDuplicate, copyCount, (book.getCopyCount() + copyCount));
			}
			return bookRepository.InsertBookAndCopies(book);
		}

		public List<BookEntity> SearchOption(string option, string value)
		{
			switch (option)
			{
				case "제목":
					return bookRepository.SelectTitle(value);
				case "저자":
					return bookRepository.SelectAuthor(value);
				default:
					return new List<BookEntity>();
			}
		}

		public BookEntity FindBook(long bookId)
		{
			return bookRepository.SelectBookId(bookId);
		}

		public List<BookCopieEntity> FindAllCopiesByBookId(long bookId)
		{
			return bookRepository.FindAllCopyBook(bookId);
		}


		private string CheckLastCharSpace(string value)
		{
			return value.TrimEnd(' ');
		}
	}
}
