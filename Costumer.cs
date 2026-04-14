namespace Pizza
{
	public class Costumer
	{
		private string _name;
		private string _phoneNumber;
		private string _email;
		private string _address;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public string PhoneNumber
		{
			get { return _phoneNumber; }
			set { _phoneNumber = value; }
		}
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		public Costumer(string name, string phoneNumber, string email, string address)
		{
			_name = name;
			_phoneNumber = phoneNumber;
			_email = email;
			_address = address;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Phone Number: {PhoneNumber}, Email: {Email}, Address: {Address}";
		}
	}
}
