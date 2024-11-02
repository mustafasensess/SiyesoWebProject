namespace SiyesoProject.Domain.Entities;

public class Team : BaseEntity
{
    public string Title { get; set; }

    public string Description { get; set; }

    public UserInfoCard UserInfoCard { get; set; }
}