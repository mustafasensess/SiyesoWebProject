namespace SiyesoProject.Domain.Entities;

public class Reference : BaseEntity
{
    public List<string> Logos { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string TitleEn { get; set; }

    public string DescriptionEn { get; set; }
}