﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository
{
	interface IRepository
	{
		MySqlConnection GetConnection();

		MySqlCommand GetCommand(string query, MySqlConnection connection);
	}
}
