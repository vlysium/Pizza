namespace Pizza
{
	public class Order : IOrder
	{
		private PizzaRegister _pizzaRegister;
		private Costumer _costumer;

		public PizzaRegister PizzaRegister
		{
			get { return _pizzaRegister; }
			set { _pizzaRegister = value; }
		}
		public Costumer Costumer
		{
			get { return _costumer; }
			set { _costumer = value; }
		}

		public Order(PizzaRegister pizzaRegister, Costumer costumer)
		{
			_pizzaRegister = pizzaRegister;
			_costumer = costumer;
		}

		public double CalculatePrice()
		{
			double vat = 1.25;
			double deliveryFee = 10;
			double calculatedPrice = 0;

			foreach (Pizza pizza in PizzaRegister.Pizzas)
			{
				calculatedPrice += pizza.Price;
			}
			calculatedPrice *= vat;

			// Apply discount if the costumer is a student
			if (Costumer is Student student)
			{
				calculatedPrice *= (1 - student.Discount);
			}

			// Apply discount and free delivery if the costumer is elderly
			if (Costumer is Elderly elderly)
			{
				calculatedPrice *= (1 - elderly.Discount);

				if (elderly.FreeDelivery)
				{
					deliveryFee = 0;
				}
			}

			return Math.Round(calculatedPrice + deliveryFee, 2);
		}

		public override string ToString()
		{
			return $"Order for {Costumer.Name} with {PizzaRegister.Pizzas.Count} pizzas.";
		}
	}
}
