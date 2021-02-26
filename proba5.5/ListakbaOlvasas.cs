using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    class ListakbaOlvasas
    {
        
        /////////////Admin_Beolvasas_Listába
        public static void AdminListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM DolgozokAdmin";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.AdminUserLista.Add(new DolgozokAdmin(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["nev"]), Convert.ToString(LekerdezesParancs["jelszo"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }
        
        ///////////Budapest_Beolvasás_Listába
        public static void BudapestUsersListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM DolgozokBP";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.BPUserLista.Add(new DolgozokBP(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["nev"]), Convert.ToString(LekerdezesParancs["jelszo"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }

        //////////Győr_Beolvasás_Listába
        
        public static void GyorUsersListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM DolgozokGY";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.GyorUserLista.Add(new DolgozokGYOR(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["nev"]), Convert.ToString(LekerdezesParancs["jelszo"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }

        //////////Debrecen_Beolvasás_Listába

        public static void DebrecenUsersListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM DolgozokD";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.DebUserLista.Add(new DolgozokDebrecen(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["nev"]), Convert.ToString(LekerdezesParancs["jelszo"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }

        //Maszk áruk Az egész
        public static void MaszarukListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM MaszkAruk";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.MaszInfokOsszes.Add(new MaszkAruk(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["maszktipus"]), Convert.ToString(LekerdezesParancs["maszknev"]),Convert.ToInt32(LekerdezesParancs["keszletarubudapest"]), Convert.ToInt32(LekerdezesParancs["keszletarugyor"]), Convert.ToInt32(LekerdezesParancs["keszletarudebrecen"]), Convert.ToDouble(LekerdezesParancs["ar_db"]), Convert.ToDouble(LekerdezesParancs["akcio"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }
    }
}
