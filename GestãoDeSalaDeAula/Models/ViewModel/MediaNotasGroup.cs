using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Models.ViewModel
{
    public class MediaNotasGroup
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double Media { get; set; }
    }
}
