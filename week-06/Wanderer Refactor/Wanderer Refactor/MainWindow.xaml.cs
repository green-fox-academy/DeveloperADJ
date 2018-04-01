using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wanderer_Refactor.Controller;
using Wanderer_Refactor.Model.Characters;
using Wanderer_Refactor.View;

namespace Wanderer_Refactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PlayerController playerController;

        public MainWindow()
        {
            InitializeComponent();

            var playerModel = new PlayerModel();
            var playerView = new PlayerView();
            playerController = new PlayerController(playerModel, playerView);
        }
    }
}
