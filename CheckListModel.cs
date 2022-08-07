public class CheckListModel
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public bool IsDone { get; set; }
    public List<CheckListItemModel>? Items { get; set; }
}
