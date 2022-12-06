using DL8TQ2_CourseProject.Module.Models;
using DL8TQ2_CourseProject.Module.ViewModels;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;

namespace DL8TQ2_CourseProject.Module.Drivers
{
    public class MapPartDisplayDriver : ContentPartDisplayDriver<MapPart>
    {
        public override IDisplayResult Display(MapPart part, BuildPartDisplayContext context) =>
            Initialize<MapPartViewModel>(
                GetDisplayShapeType(context),
                viewModel => PopulateViewModel(part, viewModel))
            .Location("Detail", "Content:5")
            .Location("Summary", "Content:5");

        public override IDisplayResult Edit(MapPart part, BuildPartEditorContext context) =>
            Initialize<MapPartViewModel>(
                GetEditorShapeType(context),
                viewModel => PopulateViewModel(part, viewModel))
            .Location("Content:5");

        public override async Task<IDisplayResult> UpdateAsync(MapPart part, IUpdateModel updater, UpdatePartEditorContext context)
        {
            var viewModel = new MapPartViewModel();

            await updater.TryUpdateModelAsync(viewModel, Prefix);

            part.GoogleMapUrl = viewModel.GoogleMapUrl;

            return await EditAsync(part, context);
        }

        private static void PopulateViewModel(MapPart part, MapPartViewModel viewModel)
        {
            viewModel.GoogleMapUrl = part.GoogleMapUrl;
        }
    }
}
