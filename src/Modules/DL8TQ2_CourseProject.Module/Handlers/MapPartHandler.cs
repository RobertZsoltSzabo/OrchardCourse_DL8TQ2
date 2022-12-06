using DL8TQ2_CourseProject.Module.Models;
using OrchardCore.ContentManagement.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL8TQ2_CourseProject.Module.Handlers
{
    public class MapPartHandler : ContentPartHandler<MapPart>
    {
        public override Task UpdatedAsync(UpdateContentContext context, MapPart instance)
        {
            context.ContentItem.DisplayText = instance.GoogleMapUrl;
            return Task.CompletedTask;
        }
    }
}
