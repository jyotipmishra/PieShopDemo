using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
	public class MockCategoryRepository : ICategoryRepository
	{
		public IEnumerable<Category> AllCategories =>
		new List<Category>{
			new Category
			{
				CategoryId = 1,
				CategoryName = "Fruit Pies",
				Description = "All fruity pies"

			},
			new Category
			{
				CategoryId = 2,
				CategoryName = "Cheese Cake",
				Description = "Cheesy all the way"

			},
			new Category
			{
				CategoryId = 3,
				CategoryName = "Seasonal Pies",
				Description = "The only seasonal delicious pie"
			}
		};
	}
}
