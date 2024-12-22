namespace Models.Entities;
public class ImageInTest
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string PathToImage { get; set; } = null!;
    public int AsymmetricScore { get; set; }
    public int DetailScore { get; set; }
    public int OriginalityFormatScore { get; set; }
    public int OriginalityTematicScore { get; set; }
    public int NameScore { get; set; }
}
