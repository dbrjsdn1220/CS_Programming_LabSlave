using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository
{
	class CommonRepository : Database_Info, IRepository
	{
		public MySqlConnection GetConnection()
		{
			return new MySqlConnection(GetonnectionString());
		}

		public MySqlCommand GetCommand(string query, MySqlConnection connection)
		{
			return new MySqlCommand(query, connection);
		}
	}
}
