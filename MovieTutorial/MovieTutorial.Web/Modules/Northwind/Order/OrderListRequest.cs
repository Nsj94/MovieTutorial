using Serenity.Services;

namespace MovieTutorial.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}