namespace AbstractPattern.Dialog;

internal class LightDialog : IDialog
{
    public void ShowDialog()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("White Dialog");
    }
}
