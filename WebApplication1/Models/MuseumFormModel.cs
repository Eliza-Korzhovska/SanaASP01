using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class MuseumFormModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteExhibit { get; set; }
        public bool SubscribeNewsletter { get; set; }
        public string VisitType { get; set; }
    }
}
