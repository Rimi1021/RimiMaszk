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
        //Listák Userek
        public static List<DolgozokAdmin> AdminUserLista = new List<DolgozokAdmin>();
        public static List<DolgozokBP> BPUserLista = new List<DolgozokBP>();
        public static List<DolgozokDebrecen> DebUserLista = new List<DolgozokDebrecen>();
        public static List<DolgozokGYOR> GyorUserLista = new List<DolgozokGYOR>();
        /// Listák Maszkok
        public static List<MaszkAruk> MaszInfokOsszes = new List<MaszkAruk>();
        
        ////Databases
        ///USEREK_Adatbázisa_INFO (rossz az elnevezés(Az összes user ott van))
        private static string FileUtvonalAdmin = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\DolgozokAdmin.mdf";
        public static string SzerverInfoAdmin = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + FileUtvonalAdmin + ";Integrated Security=True";
        
    }
}
