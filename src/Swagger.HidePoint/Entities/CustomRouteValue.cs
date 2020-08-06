namespace Swagger.HidePoint.Entities
{
    public class CustomRouteValue
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string RelativePath { get; set; }
        public bool is_hidden{ get; set; }
    }
}
