using DL8TQ2_CourseProject.Module.Models;
using OrchardCore.ContentManagement.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL8TQ2_CourseProject.Module.Handlers
{
    public class FoodItemPartHandler : ContentPartHandler<FoodItemPart>
    {
        public override Task UpdatedAsync(UpdateContentContext context, FoodItemPart instance)
        {
            context.ContentItem.DisplayText = instance.Name;
            return Task.CompletedTask;
        }
    }
}
