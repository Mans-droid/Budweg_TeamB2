using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Budweg_WPF
{
    /// <summary>
    /// Interaction logic for ProduktionsOverblik.xaml
    /// </summary>
    public partial class ProduktionsOverblik : Window
    {

        public string WorkOrderNr { get; set; }// Nok ikke dette, liste eller noget
        public string OrderNr { get; set; }// Nok ikke dette
        public string StationID { get; set; }// Nok ikke dette
        public string Station { get; set; }
        public string DateTimeIn { get; set; }
        public string DateTimeOut { get; set; }
        public string Ansvarlig { get; set; }
        public string Tilgang { get; set; }
        public string AfgangFrem { get; set; }
        public string AfgangTilbage { get; set; } 
        public string Spild { get; set; } = "4"; //binder 4 nu
        public ProduktionsOverblik()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void btnRetur_Click(object sender, RoutedEventArgs e)
        {
            var secondWindow = new MainWindow();
            secondWindow.Show();

            this.Close(); // lukker
        }
    }
}
