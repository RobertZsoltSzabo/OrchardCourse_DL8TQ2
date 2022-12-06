using System.ComponentModel.DataAnnotations;

namespace DL8TQ2_CourseProject.Module.ViewModels
{
	public class FoodItemPartViewModel
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public int Price { get; set; }
		public bool Vegan { get; set; } = false;
		public bool GlutenFree { get; set; } = false;
	}
}
