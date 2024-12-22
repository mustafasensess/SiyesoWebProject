namespace SiyesoProject.Domain.Entities;

public class InfoBox : BaseEntity
{
    public string Description { get; set; }
    
    public string Title { get; set; }

    public string TitleEn { get; set; }

    public string DescriptionEn { get; set; }

    public string Image { get; set; }
    
}