using System;
using ExerciseOopHierarchy;
using System.Collections.Generic;
using System.Linq;
namespace ExerciseOopHierarchy
{
	public class Restaurant
	{
		private List<Customer> _customers = new();
		private List<MenuItem> _menuItems = new();

		public void AddCustomer(Customer customer)
		{
			this._customers.Add(customer);
		}

		public MenuItem GetMenuItem(int index)
		{
			if (index >= _menuItems.Count)
				throw new IndexOutOfRangeException();

			return _menuItems [index];
		}

		public void AddMenuItem(MenuItem item)
		{
			this._menuItems.Add(item);
		}

		public void PlaceOrder(Customer customer, Order order)
		{
			customer.AddOrder(order);
		}

		public void DisplayMenu()
		{
			Console.WriteLine("Menu Items");

            foreach (MenuItem item in _menuItems)
			{
				Console.WriteLine(item.ToString);
			}
		}

		public void DisplayOrderHistory(Customer customer)
		{
			Console.WriteLine($"{customer.Name}'s Order History:");

			foreach (Order order in customer.Items)
			{
				Console.WriteLine($"Order Total: {order.GetTotal()}");
				foreach (MenuItem item in order.Items)
				{
					Console.WriteLine($" {item}");
				}
			}

			
		}


	}
}

