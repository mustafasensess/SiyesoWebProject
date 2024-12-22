namespace SiyesoProject.Domain.Entities;

public class AboutUs : BaseEntity
{
    public string Title { get; set; }
    
    public string Description { get; set; }

    public string Picture { get; set; }

    public string TitleEn { get; set; }
    
    public string DescriptionEn { get; set; }
}