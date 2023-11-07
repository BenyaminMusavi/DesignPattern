using AbstractPattern.Dialog;
using AbstractPattern.ToolBar;

namespace AbstractPattern.AbstractFactory;

internal class LightThemeFactory: IThemeAbstractFactory
{
    public IDialog GetDialog()
    {
        IDialog lightDialog = new LightDialog();
        return lightDialog;
    }

    public IToolBar GetToolbar()
    {
        IToolBar lightToolbar = new LightToolBar();
        return lightToolbar;
    }
}
