using Microsoft.OpenApi.Models;
using Swagger.HidePoint.Attributes;
using Swagger.HidePoint.Entities;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Swagger.HidePoint
{
    public class HidePointFilter : IDocumentFilter
    {
        public void Apply(
            OpenApiDocument swaggerDoc,
            DocumentFilterContext context
            )
        {
            try
            {
                List<CustomRouteValue> customRouteValues =
                context.ApiDescriptions.Select(x => new CustomRouteValue
                {
                    Controller = x.ActionDescriptor.RouteValues.FirstOrDefault(x => x.Key == "controller").Value,
                    Action = x.ActionDescriptor.RouteValues.FirstOrDefault(x => x.Key == "action").Value,
                    RelativePath = x.RelativePath,
                    is_hidden = x.ActionDescriptor.EndpointMetadata.FirstOrDefault(x => x.GetType() == typeof(HideAttribute)) != null ? true : false
                }).ToList();

                customRouteValues?.RemoveAll(x => !x.is_hidden);

                if (customRouteValues.Count < 1)
                    return;

                foreach (CustomRouteValue routeValue in customRouteValues)
                    swaggerDoc.Paths.Remove($"/{routeValue.RelativePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
