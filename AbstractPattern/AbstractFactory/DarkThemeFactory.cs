using AbstractPattern.Dialog;
using AbstractPattern.ToolBar;

namespace AbstractPattern.AbstractFactory;

internal class DarkThemeFactory : IThemeAbstractFactory
{
    public IDialog GetDialog()
    {
        IDialog darkDialog = new DarkDialog();
        return darkDialog;
    }

    public IToolBar GetToolbar()
    {
        IToolBar darkToolBar = new DarkToolBar();
        return darkToolBar;
    }
}
