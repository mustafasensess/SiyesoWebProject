namespace SiyesoProject.Domain.Entities;

public class AboutUs : BaseEntity
{
    public string Title { get; set; }
    
    public List<string> Description { get; set; }

    public string Picture { get; set; }

    public string TitleEn { get; set; }
    
    public List<string> DescriptionEn { get; set; }
}