namespace Pizza
{
	public class PizzaRegister
	{
		private List<Pizza> _pizzas;

		public List<Pizza> Pizzas
		{
			get { return _pizzas; }
			set { _pizzas = value; }
		}

		public PizzaRegister()
		{
			_pizzas = new List<Pizza>();
		}

		public void AddPizza(Pizza pizza)
		{
			_pizzas.Add(pizza);
		}

		public override string ToString()
		{
			return $"Pizza Register with {Pizzas.Count} pizzas";
		}
	}
}
