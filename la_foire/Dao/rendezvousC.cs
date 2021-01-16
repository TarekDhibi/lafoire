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
    class rendezvousC
    {
        public static List<rendezvous> GetAllrappelRendezvous()
        {
            List<rendezvous> list = new List<rendezvous>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = "SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, daterdv, heurerdv, notedaterdv, adresse, contact FROM 	rendezvous";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new rendezvous
                    {

                        ID = dt.GetInt16(0),
                        IDENTREPRISE = dt.GetInt16(1),
                        DATE = dt.GetString(2),
                        HEURE = dt.GetString(3),
                        NUMTEL = dt.GetString(4),
                        NOM = dt.GetString(5),
                        PRENOM = dt.GetString(6),
                        POSTE = dt.GetString(7),
                        REPONSE = dt.GetString(8),
                        DATERDV = dt.GetString(9),
                        HEURERDV = dt.GetString(10),
                        NOTEDATERDV = dt.GetString(11),
                        ADRESSE = dt.GetString(12),
                        CONTACT = dt.GetString(13)

                    });
                }
                con.CloseConnection();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "azerty");
                return null;
            }
        }

        public static List<rendezvous> GetAllRappelRendezvousfiltre(String champ, String texte)
        {
            List<rendezvous> list = new List<rendezvous>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, daterdv, heurerdv, notedaterdv, adresse, contact FROM rendezvous WHERE " + champ + " like '%" + texte + "%'";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new rendezvous
                    {


                        ID = dt.GetInt16(0),
                        IDENTREPRISE = dt.GetInt16(1),
                        DATE = dt.GetString(2),
                        HEURE = dt.GetString(3),
                        NUMTEL = dt.GetString(4),
                        NOM = dt.GetString(5),
                        PRENOM = dt.GetString(6),
                        POSTE = dt.GetString(7),
                        REPONSE = dt.GetString(8),
                        DATERDV = dt.GetString(9),
                        HEURERDV = dt.GetString(10),
                        NOTEDATERDV = dt.GetString(11),
                        ADRESSE = dt.GetString(12),
                        CONTACT = dt.GetString(13)
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

        #region AjouterRappelRendezvous()
        public static int AjouterRappelRendezvous(rendezvous rap)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "INSERT INTO rendezvous(identreprise, date, heure, numtel, nom, prenom, poste, reponse, daterdv, heurerdv, notedaterdv, adresse, contact) VALUES (" + rap.IDENTREPRISE + ",'" + rap.DATE + "','" + rap.HEURE + "','" + rap.NUMTEL + "','" + rap.NOM + "','" + rap.PRENOM + "','" + rap.POSTE + "','" + rap.REPONSE + "','" + rap.DATERDV + "','" + rap.HEURERDV + "','" + rap.NOTEDATERDV + "','" + rap.ADRESSE + "','" + rap.CONTACT + "')";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }

        }
        #endregion
        #region ModifierRappelRendezvous()
        public static int ModifierRappelRendezvous(rendezvous rap, int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "UPDATE  	rendezvous SET identreprise =" + rap.IDENTREPRISE + ", date='" + rap.DATE + "', heure='" + rap.HEURE + "',numtel='" + rap.NUMTEL + "',nom='" + rap.NOM + "',prenom='" + rap.PRENOM + "',poste='" + rap.POSTE + "',reponse='" + rap.REPONSE + "',daterdv='" + rap.DATERDV + "',heurerdv='" + rap.HEURERDV + "',notedaterdv='" + rap.NOTEDATERDV + "',adresse='" + rap.ADRESSE + "',contact='" + rap.CONTACT + "'  WHERE id=" + idd + " ";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }

        }
        #endregion
        #region SupprimerRappelRendezvous()
        public static int SupprimerRappelRendezvous(int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "DELETE FROM rendezvous WHERE id=" + idd + " ";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }

        }
        #endregion
    }
}
