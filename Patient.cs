using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betegek
{
    public class Patient
    {

        private List<Treatment> treatments = new List<Treatment>();

        public string Name { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Taj { get; set; }
        public List<Treatment> Treatments { get => treatments; }

    }
}
