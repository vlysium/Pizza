namespace Pizza
{
	public enum Size
	{
		Medium,
		Large
	}

	public class Pizza
	{
		private int _pizzaNumber;
		private string _name;
		private Size _size;
		private double _price;
		private string _content;

		public int PizzaNumber
		{
			get { return _pizzaNumber; }
			set { _pizzaNumber = value; }
		}
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public Size Size
		{
			get { return _size; }
			set { _size = value; }
		}
		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}
		public string Content
		{
			get { return _content; }
			set { _content = value; }
		}

		public Pizza(int pizzaNumber, string name, Size size, double price, string content)
		{
			_pizzaNumber = pizzaNumber;
			_name = name;
			_size = size;
			_price = price;
			_content = content;
		}

		public override string ToString()
		{
			return $"Pizza Number: {PizzaNumber}, Name: {Name}, Size: {Size}, Price: {Price}, Content: {Content}";
		}
	}
}
