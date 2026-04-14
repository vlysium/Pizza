namespace Pizza
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Costumer costumer = new Costumer("John Doe", "12 34 56 78", "john.doe@email.com", "Maglegårdsvej 2, 4000 Roskilde");
			PizzaRegister pizzaRegister = new PizzaRegister();

			Pizza pizza1 = new Pizza(2, "Margherita", Size.Medium, 55.50, "Tomato sauce, mozzarella cheese, basil");
			pizzaRegister.AddPizza(pizza1);

			Pizza pizza2 = new Pizza(3, "Salad Pizza", Size.Medium, 57.50, "Tomato sauce, mozzarella cheese, salad, dressing, kebab");
			pizzaRegister.AddPizza(pizza2);
			
			Order order = new Order(pizzaRegister, costumer);

			Console.WriteLine(order.ToString());
			Console.WriteLine($"The price is {order.CalculatePrice()} DKK inclusive 25% VAT");
		}
	}
}
