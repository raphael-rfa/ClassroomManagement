using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Web.ViewModels;

public class AverageScoreGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }

    [DisplayFormat(DataFormatString = "{0:0.00}")]
    public double Average { get; set; }
}
