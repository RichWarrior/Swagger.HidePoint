using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Swagger.HidePoint
{
    public static class HidePointUtility      
    {
        public static void EnableHidePoint<HideUtility>(this SwaggerGenOptions swaggerGenOptions) 
            where HideUtility : IDocumentFilter
        {
            swaggerGenOptions.DocumentFilter<HideUtility>();
        }
    }
}
