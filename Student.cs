namespace Pizza
{
	public class Student : Costumer
	{
		private double _discount;

		public double Discount
		{
			get { return _discount; }
			private set { _discount = value; }	
		}

		public Student(string name, string phoneNumber, string email, string address) : base(name, phoneNumber, email, address) { }

		public void AddDiscount(double discount)
		{
			Discount = discount;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Phone Number: {PhoneNumber}, Email: {Email}, Address: {Address}, Discount: {Discount * 100}%";
		}
	}
}
