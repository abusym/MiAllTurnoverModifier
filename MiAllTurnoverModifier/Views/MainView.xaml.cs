using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace MiAllTurnoverModifier.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView
    {
        public MainView()
        {
            StyleManager.ApplicationTheme = new GreenTheme();
            GreenPalette.LoadPreset(GreenPalette.ColorVariation.Light);
            GreenPalette.Palette.FontSize = 16;

            InitializeComponent();
        }
    }
}
