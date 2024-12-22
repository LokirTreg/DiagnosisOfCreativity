using System.ComponentModel;

namespace Models.Entities;
public class Test
{
    public int Id { get; set; }
    public string PathToImage { get; set; } = null!;
    [Description("Сумма ОРФ, Р1, Р2 и Н")]
    public int TotalWillScore { get; set; }
    [Description("Оценка Вилла минус ОРТ")]
    public int TotalCretiveScore { get; set; }
    [Description("Сцмма оценок ОРТ")]
    public int OriginalityTematicScore { get; set; }
    [Description("Сумма баллов по ОРТ и Названию")]
    public int SubScore { get; set; }
}