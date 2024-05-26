using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository
{
	class Database_Info
	{
		private const string DB_SERVER_ID = "localhost";
		private const string DB_NAME = "bookdb";
		private const string DB_ID = "root";
		private const string DB_PASSWORD = "1234";

		protected string GetConnectionString()
		{
			return "Server=" + DB_SERVER_ID + ";Database=" + DB_NAME + ";Uid=" + DB_ID + ";Pwd=" + DB_PASSWORD + ";";
		}
	}
}
