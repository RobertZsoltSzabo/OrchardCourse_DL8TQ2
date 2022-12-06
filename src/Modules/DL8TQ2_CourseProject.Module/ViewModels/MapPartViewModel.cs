using System.ComponentModel.DataAnnotations;

namespace DL8TQ2_CourseProject.Module.ViewModels
{
	public class MapPartViewModel
	{
		[Required]
		public string GoogleMapUrl { get; set; }
	}
}
