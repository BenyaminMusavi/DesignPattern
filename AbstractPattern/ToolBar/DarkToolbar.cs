namespace AbstractPattern.ToolBar;

internal class DarkToolBar: IToolBar
{
    public void ShowToolBar()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Dark Toolbar");
    }
}
