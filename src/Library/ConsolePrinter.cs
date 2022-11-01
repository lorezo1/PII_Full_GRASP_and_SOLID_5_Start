using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent) // Cambiado por DIP
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}