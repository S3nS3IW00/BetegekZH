using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace Betegek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ViewModel vm;

        public MainWindow()
        {
            vm = new ViewModel();

            InitializeComponent();
            this.DataContext = vm;

            Edit.IsEnabled = false;
            Treatment.IsEnabled = false;
        }

        private void OnNew(object sender, RoutedEventArgs e)
        {
            PatientData patientWindow = new PatientData(null);
            patientWindow.ShowDialog();
            if (patientWindow.DialogResult == true)
            {
                vm.Patients.Add(patientWindow.Patient);
            }
        }

        private void OnEdit(object sender, RoutedEventArgs e)
        {
            int currentIndex = PatientBox.SelectedIndex;
            PatientData patientWindow = new PatientData(vm.Patients[currentIndex]);
            patientWindow.ShowDialog();
            if (patientWindow.DialogResult == true)
            {
                vm.Patients.RemoveAt(currentIndex);
                vm.Patients.Insert(currentIndex, patientWindow.Patient);
            }
        }

        private void OnTreament(object sender, RoutedEventArgs e)
        {
            int currentIndex = PatientBox.SelectedIndex;
            Treatments treatmentWindow = new Treatments(vm.Patients[currentIndex]);
            treatmentWindow.ShowDialog();
            if (treatmentWindow.DialogResult == true)
            {
                treatmentWindow.Patient.Treatments.Add(treatmentWindow.Treatment);
            }
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count == 0)
            {
                Edit.IsEnabled = false;
                Treatment.IsEnabled = false;
            }
            else
            {
                Edit.IsEnabled = true;
                Treatment.IsEnabled = true;
            }
        }
    }
}
