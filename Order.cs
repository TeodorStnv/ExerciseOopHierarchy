using System;
using ExerciseOopHierarchy;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOopHierarchy
{
	public class Order 
	{
		private List<MenuItem> _items = new();
        public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();

        public void AddItem(MenuItem item)
		{
			this._items.Add(item);
		}

		public decimal GetTotal()
		{
            return this._items.Select(i => i.Price).Sum();
			//взимам списъка-на всеки от елементите му взимам цената-и ги сумирам
		}

	}
}

