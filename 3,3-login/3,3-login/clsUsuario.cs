using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_login
{
	internal class clsUsuario
	{
		private int userid;
		private string firstname;
		private string lastname;
		private string username;
		private string password;
		private string email;
		private string description;
		private bool userstatus;
		private DateTime createddate;

		public int UserId
		{
			get { return userid; }
			set { userid = value; }
		}

		public string FirstName
		{
			get { return firstname; }
			set { firstname = value; }
		}

		public string LastName
		{
			get { return lastname; }
			set { lastname = value; }
		}

		public string UserName
		{
			get { return username; }
			set { username = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public bool UserStatus
		{
			get { return userstatus; }
			set { userstatus = value; }
		}

		public DateTime CreatedDate
		{
			get { return createddate; }
			set { createddate = value; }
		}
	}
}
