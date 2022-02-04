using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            //check if window is already open

            var openForms = Application.OpenForms.Cast<Form>();
            var isopen = openForms.Any(x => x.Name == name);
            return isopen;
        }
    }
}
