using starlinktaxi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betegek
{
    public class ViewModel : Bindable
    {

        private ObservableCollection<Patient> patients = new ObservableCollection<Patient>();

        public ObservableCollection<Patient> Patients { get => patients; }

    }
}
