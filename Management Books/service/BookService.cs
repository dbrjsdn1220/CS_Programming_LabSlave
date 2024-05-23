using Management_Books.repository.book;
using System;
using System.Collections.Generic;
using System.Linq;
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
			return bookRepository.Insert(book);
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

	}
}
