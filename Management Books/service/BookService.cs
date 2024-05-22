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

		public List<BookEntity> Start()
		{
			return bookRepository.GetBooks();
		}

		public List<BookEntity> searchTitle(string title)
		{
			return bookRepository.SelectTitle(title);
		}

	}
}
