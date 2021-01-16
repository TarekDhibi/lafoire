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
    class arappelerC
    {
        public static List<arappeler> GetAllrappelArappeler()
        {
            List<arappeler> list = new List<arappeler>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = "SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, tel1, note1, tel2, note2, daterap, heurerap, notedaterap, causerap, notecauserap, priorite FROM arappeler";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new arappeler
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
                        TEL1 = dt.GetString(9),
                        NOTE1 = dt.GetString(10),
                        TEL2 = dt.GetString(11),
                        NOTE2 = dt.GetString(12),
                        DATERAP = dt.GetString(13),
                        HEURERAP = dt.GetString(14),
                        NOTEDATERAP = dt.GetString(15),
                        CAUSERAP = dt.GetString(16),
                        NOTECAUSERAP = dt.GetString(17),                     
                        PRIORITE = dt.GetString(18)
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

        public static List<arappeler> GetAllRappelArappelerfiltre(String champ, String texte)
        {
            List<arappeler> list = new List<arappeler>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, tel1, note1, tel2, note2, daterap, heurerap, notedaterap, causerap, notecauserap, priorite  FROM 	arappeler WHERE " + champ + " like '%" + texte + "%'";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new arappeler
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
                        TEL1 = dt.GetString(9),
                        NOTE1 = dt.GetString(10),
                        TEL2 = dt.GetString(11),
                        NOTE2 = dt.GetString(12),
                        DATERAP = dt.GetString(13),
                        HEURERAP = dt.GetString(14),
                        NOTEDATERAP = dt.GetString(15),
                        CAUSERAP = dt.GetString(16),
                        NOTECAUSERAP = dt.GetString(17),
                        PRIORITE = dt.GetString(18)
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

        #region AjouterRappelArappele()
        public static int AjouterRappelArappeler(arappeler rap)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "INSERT INTO arappeler(identreprise, date, heure, numtel, nom, prenom, poste, reponse, tel1, note1, tel2, note2, daterap, heurerap, notedaterap, causerap, notecauserap, priorite) VALUES (" + rap.IDENTREPRISE + ",'" + rap.DATE + "','" + rap.HEURE + "','" + rap.NUMTEL + "','" + rap.NOM + "','" + rap.PRENOM + "','" + rap.POSTE + "','" + rap.REPONSE + "','" + rap.TEL1 + "','" + rap.NOTE1 + "','" + rap.TEL2 + "','" + rap.NOTE2 + "','" + rap.DATERAP + "','" + rap.HEURERAP + "','" + rap.NOTEDATERAP + "','" + rap.CAUSERAP + "','" + rap.NOTECAUSERAP + "','" + rap.PRIORITE + "')";
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
        #region ModifierRappelArappeler()
        public static int ModifierRappelArappeler(arappeler rap, int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "UPDATE arappeler SET identreprise =" + rap.IDENTREPRISE + ", date='" + rap.DATE + "', heure='" + rap.HEURE + "',numtel='" + rap.NUMTEL + "',nom='" + rap.NOM + "',prenom='" + rap.PRENOM + "',poste='" + rap.POSTE + "',reponse='" + rap.REPONSE + "',tel1='" + rap.TEL1 + "',note1='" + rap.NOTE1 + "',tel2='" + rap.TEL2 + "',note2='" + rap.NOTE2 + "',daterap='" + rap.DATERAP + "',heurerap='" + rap.HEURERAP + "',notedaterap='" + rap.NOTEDATERAP + "' ,causerap='" + rap.CAUSERAP + "',notecauserap='" + rap.NOTECAUSERAP + "',priorite='" + rap.PRIORITE + "'    WHERE id=" + idd + " ";
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
        #region SupprimerRappelArappeler()
        public static int SupprimerRappelArappeler(int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "DELETE FROM arappeler WHERE id=" + idd + " ";
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
