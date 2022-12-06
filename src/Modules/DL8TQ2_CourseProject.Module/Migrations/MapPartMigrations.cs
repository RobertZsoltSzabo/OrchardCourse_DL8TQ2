using DL8TQ2_CourseProject.Module.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;

namespace DL8TQ2_CourseProject.Module.Migrations
{
    public class MapPartMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public MapPartMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
			_contentDefinitionManager.AlterPartDefinition(nameof(MapPart), part => part
				.Attachable()
			);

			return 1;
        }

        public int UpdateFrom1()
        {
			_contentDefinitionManager.AlterTypeDefinition("MapWidget", type => type
	            .WithPart(nameof(MapPart))
	            .Stereotype("Widget")
            );

            return 2;
		}
    }
}
