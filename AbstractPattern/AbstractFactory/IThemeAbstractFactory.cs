using AbstractPattern.Dialog;
using AbstractPattern.ToolBar;

namespace AbstractPattern.AbstractFactory;

internal interface IThemeAbstractFactory
{
    IDialog GetDialog();
    IToolBar GetToolbar();
}
