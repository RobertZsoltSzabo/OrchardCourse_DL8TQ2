using DL8TQ2_CourseProject.Module.Models;
using DL8TQ2_CourseProject.Module.ViewModels;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL8TQ2_CourseProject.Module.Drivers
{
    public class FoodItemPartDisplayDriver : ContentPartDisplayDriver<FoodItemPart>
    {
        public override IDisplayResult Display(FoodItemPart part, BuildPartDisplayContext context) =>
            Initialize<FoodItemPartViewModel>(
                GetDisplayShapeType(context),
                viewModel => PopulateViewModel(part, viewModel))
            .Location("Detail", "Content:5")
            .Location("Summary", "Content:5");

        public override IDisplayResult Edit(FoodItemPart part, BuildPartEditorContext context) =>
            Initialize<FoodItemPartViewModel>(
                GetEditorShapeType(context),
                viewModel => PopulateViewModel(part, viewModel))
            .Location("Content:5");

        public override async Task<IDisplayResult> UpdateAsync(FoodItemPart part, IUpdateModel updater, UpdatePartEditorContext context)
        {
            var viewModel = new FoodItemPartViewModel();

            await updater.TryUpdateModelAsync(viewModel, Prefix);

            part.Name = viewModel.Name;
            part.Description = viewModel.Description;
            part.Price = viewModel.Price;
            part.Vegan = viewModel.Vegan;
            part.GlutenFree = viewModel.GlutenFree;

            return await EditAsync(part, context);
        }

        private static void PopulateViewModel(FoodItemPart part, FoodItemPartViewModel viewModel)
        {
			viewModel.Name = part.Name;
			viewModel.Description = part.Description;
			viewModel.Price = part.Price;
			viewModel.Vegan = part.Vegan;
			viewModel.GlutenFree = part.GlutenFree;
		}
    }
}
