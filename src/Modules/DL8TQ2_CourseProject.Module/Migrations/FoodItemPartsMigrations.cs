using DL8TQ2_CourseProject.Module.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;

namespace DL8TQ2_CourseProject.Module.Migrations
{
	public class FoodItemPartsMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public FoodItemPartsMigrations(IContentDefinitionManager contentDefinitionManager) =>
            _contentDefinitionManager = contentDefinitionManager;

        public int Create()
        {
			_contentDefinitionManager.AlterPartDefinition(nameof(FoodItemPart), part => part
				.Attachable()
				.Reusable()
			);

			_contentDefinitionManager.AlterTypeDefinition("FoodItemWidget", type => type
				.WithPart(nameof(FoodItemPart))
				.Stereotype("Widget")
			);

			return 3;
        }
		public int UpdateFrom1()
		{


			return 2;
		}

		public int UpdateFrom2()
		{
			_contentDefinitionManager.AlterPartDefinition(nameof(FoodItemPart), part => part
				.Attachable()
				.Reusable()
			);

			_contentDefinitionManager.AlterTypeDefinition("FoodItemWidget", type => type
				.WithPart(nameof(FoodItemPart))
				.Stereotype("Widget")
			);

			return 3;
		}
	}
}
