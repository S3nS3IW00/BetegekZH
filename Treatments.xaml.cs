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
using System.Windows.Shapes;

namespace Betegek
{
    /// <summary>
    /// Interaction logic for Treatments.xaml
    /// </summary>
    public partial class Treatments : Window
    {

        public Patient Patient { get; set; }
        public Treatment Treatment { get; set; }
        public string[] BNOCodes { get => new string[]
            {
            "123 - Elhízás",
            "456 - Valami",
            "789 - Még valami"
            };
            }

        public Treatments(Patient patient)
        {
            Patient = patient;

            InitializeComponent();
            this.DataContext = this;
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            if (Note.Text == "")
            {
                MessageBox.Show("Hibás adat(ok)!");
            } else
            {
                Treatment = new Treatment() { BNOCode = BNOCodeBox.SelectedItem.ToString(), Note = Note.Text };
                this.DialogResult = true;
            }
        }
    }
}
