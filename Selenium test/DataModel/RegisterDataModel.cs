﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_test.DataModel
{
	public class RegisterDataModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}
	public class RegisterList
	{
		private List<RegisterDataModel> register;
		public List<RegisterDataModel> Register { get => register; set => register = value; }
	}
}
