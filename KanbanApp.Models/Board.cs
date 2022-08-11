namespace KanbanApp.Models;

public class Board
{
    public string name { get; set; }
    public Column[] columns { get; set; }
}