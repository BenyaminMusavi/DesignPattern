namespace AbstractPattern.Dialog;

internal class DarkDialog : IDialog
{
    public void ShowDialog()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Dark Dialog");
    }
}
