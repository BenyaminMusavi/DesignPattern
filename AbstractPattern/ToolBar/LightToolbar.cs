namespace AbstractPattern.ToolBar;

internal class LightToolBar : IToolBar
{
    public void ShowToolBar()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("White Toolbar");
    }
}
