using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MiAllTurnoverModifier.Views;
using Prism.Ioc;
using Prism.Regions;
using Telerik.Windows.Controls;

namespace MiAllTurnoverModifier
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return null;
        }

        protected override void OnInitialized()
        {
            var mainView = Container.Resolve<MainView>();
            mainView.Show();
            MainWindow = mainView.ParentOfType<Window>();

            // there lines was not executed because of null Shell - so must duplicate here. Originally called from PrismApplicationBase.Initialize
            RegionManager.SetRegionManager(MainWindow, Container.Resolve<IRegionManager>());
            RegionManager.UpdateRegions();
            InitializeModules();

            base.OnInitialized();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
