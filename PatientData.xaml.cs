using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Betegek
{
    /// <summary>
    /// Interaction logic for PatientData.xaml
    /// </summary>
    public partial class PatientData : Window
    {

        public Patient Patient { get; set; }

        public PatientData(Patient patient)
        {
            Patient = patient;
            if (Patient == null)
            {
                Patient = new Patient() { DateOfBirth = System.DateTime.Now };
            }

            InitializeComponent();
            this.DataContext = this;
        }

        private void OnTajInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "" || PlaceOfBirth.Text == "" || DateOfBirth.SelectedDate == null || Taj.Text == "")
            {
                MessageBox.Show("Hibás adat(ok)!");
            }
            else
            {
                Patient.Name = Name.Text;
                Patient.PlaceOfBirth = PlaceOfBirth.Text;
                Patient.DateOfBirth = DateOfBirth.SelectedDate.Value;
                Patient.Taj = int.Parse(Taj.Text);
                this.DialogResult = true;
            }
        }
    }
}
