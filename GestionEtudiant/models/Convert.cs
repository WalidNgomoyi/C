using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.models
{
    class Convert
    {
        private static string modulesSting;

        public static string ListToString(List<string> modules, string grade)
        {
            string modulesSting = "";
            foreach (var elt in modules)
            {
                modulesSting += elt + ";";
            }
            return modulesSting;
        }

        public static List<string> StringToList(string modules)
        {
            return modules.Split(';').ToList();
        }
    }
}
