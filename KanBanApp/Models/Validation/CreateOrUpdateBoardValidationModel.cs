using System.ComponentModel.DataAnnotations;

namespace KanBanApp.Models.Validation;

public class CreateOrUpdateBoardValidationModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Your todo must have a title")]
    public string? Name { get; set; }

    public List<Column>? Columns { get; set; }
}