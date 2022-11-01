
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
        //Cambiado por DIP
         void PrintRecipe(IRecipeContent recipe);
    }
}