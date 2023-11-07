using AbstractPattern.AbstractFactory;
using AbstractPattern.Dialog;
using AbstractPattern.ToolBar;

IThemeAbstractFactory themeAbstractFactory = FactoryProvider.GetFactory(AbstractPattern.Theme.Dark);

IToolBar toolBar = themeAbstractFactory.GetToolbar();
toolBar.ShowToolBar();

IDialog dialog = themeAbstractFactory.GetDialog();
dialog.ShowDialog();

Console.ReadLine();