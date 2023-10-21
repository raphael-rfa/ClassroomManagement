using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Models.ViewModel
{
    public class AverageScoreGroup
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double Average { get; set; }
    }
}
