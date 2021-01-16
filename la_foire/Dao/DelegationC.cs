using la_foire.Ent;
using la_foire.Tech;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace la_foire.Dao
{
    class DelegationC
    {
        public static List<delegation> GetDel(int id)
        {
            List<delegation> list = new List<delegation>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT id, nom FROM delegation WHERE idgouv='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new delegation
                    {

                        ID = dt.GetInt16(0),
                        NOM = dt.GetString(1)

                    });
                }
                con.CloseConnection();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

    }
}
