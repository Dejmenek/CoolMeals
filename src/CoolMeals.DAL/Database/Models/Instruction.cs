namespace CoolMeals.DAL.Database.Models;
public class Instruction
{
    public int InstructionId { get; set; }
    public int RecipeId { get; set; }
    public int StepNumber { get; set; }
    public string Description { get; set; } = string.Empty;
    public Recipe Recipe { get; set; } = null!;
}
