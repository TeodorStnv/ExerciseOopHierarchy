using System;
using ExerciseOopHierarchy;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOopHierarchy
{
	public class Customer
	{
		private List<Order> _orderHistory = new();

		public string Name { get; set; }
		public string Email { get; set; }

        public IReadOnlyCollection<Order> Items => this._orderHistory.AsReadOnly();

		public Customer(string name, string email)
		{
			Name = name;
			Email = email;
		}

		public void AddOrder(Order order)
		{
			this._orderHistory.Add(order);
		}
    }
}

