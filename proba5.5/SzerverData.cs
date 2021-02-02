using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proba5._5
{
    class SzerverData
    {
        public static List<DolgozokAdmin> AdminUserLista = new List<DolgozokAdmin>();
        public static List<DolgozokBP> BPUserLista = new List<DolgozokBP>();
        public static List<DolgozokDebrecen> DebUserLista = new List<DolgozokDebrecen>();
        public static List<DolgozokGYOR> GyorUserLista = new List<DolgozokGYOR>();
        ////Databases
        ///Admin
        public static string FileUtvonalAdmin = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\DolgozokAdmin.mdf";
        public static string SzerverInfoAdmin = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + FileUtvonalAdmin + ";Integrated Security=True";
        ///BPUsers
        public static string FileUtvonalBP = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\DolgozokBP.mdf";
        public static string SzerverInfoBP = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + FileUtvonalBP + ";Integrated Security = True";
        ///GyorUsers
        public static string FileUtvonalGY = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\DolgozokGY.mdf";
        public static string SzerverInfoGY = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + FileUtvonalGY + ";Integrated Security = True";
        ///DebUsers
        public static string FileUtvonalDeb = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\DolgozokD.mdf";
        public static string SzerverInfoDeb = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + FileUtvonalDeb + ";Integrated Security = True";
    }
}
