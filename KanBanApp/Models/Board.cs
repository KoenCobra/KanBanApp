namespace KanBanApp.Models;

public class Board
{
    //[Required(AllowEmptyStrings = false, ErrorMessage = "Your board must have a title")]
    public string? name { get; set; }

    public List<Column>? columns { get; set; }
}