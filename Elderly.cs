namespace Pizza
{
	public class Elderly : Costumer
	{
		private bool _freeDelivery;
		private double _discount;

		public bool FreeDelivery
		{
			get { return _freeDelivery; }
			set { _freeDelivery = value; }
		}
		public double Discount
		{
			get { return _discount; }
			private set { _discount = value; }
		}

		public Elderly(string name, string phoneNumber, string email, string address) : base(name, phoneNumber, email, address)
		{
			_freeDelivery = true;
		}

		public void AddDiscount(double discount)
		{
			Discount = discount;
		}

		public override string ToString()
		{
			return $"Elderly: {Name}, Phone: {PhoneNumber}, Email: {Email}, Address: {Address}, Free Delivery: {FreeDelivery}, Discount: {Discount * 100}%";
		}
	}
}
