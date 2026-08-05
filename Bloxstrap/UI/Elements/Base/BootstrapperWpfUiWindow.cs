using System.Windows;
using System.Windows.Interop;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;
using Wpf.Ui.Markup;
using Wpf.Ui.Mvvm.Contracts;
using Wpf.Ui.Mvvm.Services;

namespace Bloxstrap.UI.Elements.Base
{
    public abstract class BootstrapperWpfUiWindow : WpfUiWindow
    {
        protected override void OnSourceInitialized(EventArgs e)
        {
            if (App.Settings.Prop.WPFSoftwareRender || App.LaunchSettings.NoGPUFlag.Active)
            {
                if (PresentationSource.FromVisual(this) is HwndSource hwndSource)
                    hwndSource.CompositionTarget.RenderMode = RenderMode.SoftwareOnly;
            }

            base.OnSourceInitialized(e);

            ThemeType type = App.Settings.Prop.BootstrapperTheme.GetFinal() == Enums.Theme.Dark ? ThemeType.Dark : ThemeType.Light;

            if (type == ThemeType.Dark)
                Wpf.Ui.Appearance.Theme.ApplyDarkThemeToWindow(this);
            else
                Wpf.Ui.Appearance.Theme.RemoveDarkThemeFromWindow(this);

            this.Resources.MergedDictionaries.Add(new ThemesDictionary { Theme =  type });
        }
    }
}
