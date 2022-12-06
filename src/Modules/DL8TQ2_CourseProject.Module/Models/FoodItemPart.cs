using OrchardCore.ContentManagement;

namespace DL8TQ2_CourseProject.Module.Models
{
	public class FoodItemPart : ContentPart
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public bool Vegan { get; set; } = false;
		public bool GlutenFree { get; set; } = false;
	}
}
