using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        //ObservableCollection er en liste der bruges til data binding med UI i xaml eks. "{Binding WorkOrders}"
        public ObservableCollection<WorkOrder> WorkOrders { get; set; } = new ObservableCollection<WorkOrder>();

        public ProduktionsOverblik()
        {
            InitializeComponent();
            // Temp data, for at se det virker
            // WorkOrder List, så der kan laves flere følgeseddler 
            WorkOrders.Add(new WorkOrder
            {
                WorkOrderNr = 123465,
                OrderNr = 234678,
                // StationID list så der kan laves flere station under en følgeseddel  
                StationID = new List<Station>
            {
                new Station
                {
                    StationName = "Renovering",
                    DateTimeIn = "12:00 - 24/12-2025",
                    DateTimeOut = "12:36 - 24/12-2025",
                    Ansvarlig = "Pia Kjærsgaard",
                    Tilgang = 30,
                    AfgangFrem = 26,
                    AfgangTilbage = 2,
                    Spild = 2
                },
                 new Station
                {
                    StationName = "KvalitetsTjek",
                    DateTimeIn = "12:37 - 24/12-2025",
                    DateTimeOut = "12:54 - 24/12-2025",
                    Ansvarlig = "Lars Lykke",
                    Tilgang = 26,
                    AfgangFrem = 24,
                    AfgangTilbage = 1,
                    Spild = 1
                },
                 new Station
                {
                    StationName = "Station Navn 1",
                    DateTimeIn = "13:00 - 24/12-2025",
                    DateTimeOut = "14:04 - 24/12-2025",
                    Ansvarlig = "Pia Olsen Dyhr",
                    Tilgang = 27,
                    AfgangFrem = 24,
                    AfgangTilbage = 3,
                    Spild = 0
                },
                 new Station
                {
                    StationName = "Staion Navn 2",
                    DateTimeIn = "14:05 - 24/12-2025",
                    DateTimeOut = "14:44 - 24/12-2025",
                    Ansvarlig = "Morten Messerschmidt",
                    Tilgang = 26,
                    AfgangFrem = 20,
                    AfgangTilbage = 2,
                    Spild = 4
                }

            }
            });
            WorkOrders.Add(new WorkOrder
            {
                WorkOrderNr = 123466,
                OrderNr = 234679,
                StationID = new List<Station>
            {
                new Station
                {
                    StationName = "Renovering",
                    DateTimeIn = "12:35 - 24/12-2025",
                    DateTimeOut = "12:56 - 24/12-2025",
                    Ansvarlig = "Mette Frederiksen",
                    Tilgang = 40,
                    AfgangFrem = 38,
                    AfgangTilbage = 0,
                    Spild = 2
                },
                 new Station
                {
                    StationName = "KvalitetsTjek",
                    DateTimeIn = "12:37 - 24/12-2025",
                    DateTimeOut = "12:54 - 24/12-2025",
                    Ansvarlig = "Simon Emil Ammitzbøll",
                    Tilgang = 38,
                    AfgangFrem = 34,
                    AfgangTilbage = 2,
                    Spild = 2
                },
                 new Station
                {
                    StationName = "Risengrød",
                    DateTimeIn = "13:00 - 24/12-2025",
                    DateTimeOut = "14:04 - 24/12-2025",
                    Ansvarlig = "Bertel Haarder",
                    Tilgang = 36,
                    AfgangFrem = 34,
                    AfgangTilbage = 1,
                    Spild = 1
                },
                 new Station
                {
                    StationName = "Staion Navn 2",
                    DateTimeIn = "14:05 - 24/12-2025",
                    DateTimeOut = "14:44 - 24/12-2025",
                    Ansvarlig = "Mogens Lykketoft",
                    Tilgang = 35,
                    AfgangFrem = 21,
                    AfgangTilbage = 9,
                    Spild = 5
                }

            }
            });

            DataContext = this; // set bindings
        }
        //Return knap
        private void btnRetur_Click(object sender, RoutedEventArgs e)
        {
            //åbner MainWindow (Menuen) 
            var main = new MainWindow();
            main.Show();
            //Lukker dette vindue
            this.Close();
        }
        //Datatime måske i stedet for string
        public class Station
        {
            public string StationName { get; set; }
            public string DateTimeIn { get; set; }
            public string DateTimeOut { get; set; }
            public string Ansvarlig { get; set; }
            public int Tilgang { get; set; }
            public int AfgangFrem { get; set; }
            public int AfgangTilbage { get; set; }
            public int Spild { get; set; }
        }

        public class WorkOrder
        {
            public int WorkOrderNr { get; set; }
            public int OrderNr { get; set; }
            public List<Station> StationID { get; set; }
        }
    }
}