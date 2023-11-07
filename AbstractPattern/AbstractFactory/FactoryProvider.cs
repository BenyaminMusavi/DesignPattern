using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern.AbstractFactory
{
    internal class FactoryProvider
    {
        public static IThemeAbstractFactory GetFactory(Theme theme)
        {
            IThemeAbstractFactory themeAbstractFactory = null;
            switch (theme)
            {
                case Theme.Light:
                    themeAbstractFactory = new LightThemeFactory();
                    break;

                case Theme.Dark:
                    themeAbstractFactory = new DarkThemeFactory();
                    break;
            }
            return themeAbstractFactory;
        }
    }
}
