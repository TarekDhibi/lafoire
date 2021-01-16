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
    class JournalPC
    {

        public static List<JournalP> GetAll( )
        {
            List<JournalP> list = new List<JournalP>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT * FROM journaladmin";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new JournalP
                    {
                        ID = dt.GetInt16(0),
                        IDADMIN = dt.GetInt16(1),
                        HEURE = dt.GetString(2),
                        ACTION = dt.GetString(3)
                        
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


        public static void ajouterJournal(JournalP journal)
        {
            try
            {
                Connexion cnx = new Connexion();
                cnx.OpenConnection();
                String requette = "INSERT INTO journaladmin (idAdmin, heure, action) VALUES  (" + journal.IDADMIN + ",'" + journal.HEURE + "','" + journal.ACTION + "' )";
                //MySql.Data.MySqlClient.MySqlCommand m1 = new MySql.Data.MySqlClient.MySqlCommand(requette, cnx.connexion);
                //m1.Connection.Open();
                MySqlCommand cmd = new MySqlCommand(requette, cnx.connexion);
                cmd.ExecuteNonQuery();
                cnx.CloseConnection();
                //m1.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /*  public static int modifierRemarque(JournalP journal)
          {
              try
              {
                  Connexion cnx = new Connexion();
                  cnx.OpenConnection();
                  String requette = "UPDATE journaladmin SET remarque ='" + journal.REMARQUE + "' WHERE id=" + journal.ID + " ";
                  MySqlCommand cmd = new MySqlCommand(requette, cnx.connexion);
                  cmd.ExecuteNonQuery();
                  cnx.CloseConnection();
                  return 1;
              }
              catch (Exception e)
              {
                  //MessageBox.Show(e.Message);
                  return 0;
              }
          }*/

    }
}
