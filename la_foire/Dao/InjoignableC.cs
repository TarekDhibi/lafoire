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
    class InjoignableC
    {

        public static List<Injoignable> GetAllrappelInjoignable()
        {
            List<Injoignable> list = new List<Injoignable>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = "SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, note FROM 	injoignable";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new Injoignable
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
                        NOTE = dt.GetString(9)
                        
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

        public static List<Injoignable> GetAllRappelInjoignablefiltre(String champ, String texte)
        {
            List<Injoignable> list = new List<Injoignable>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, note  FROM 	injoignable WHERE " + champ + " like '%" + texte + "%'";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new Injoignable
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
                        NOTE = dt.GetString(9)
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

        #region AjouterRappelInjoignable()
        public static int AjouterRappelInjoignable(Injoignable rap)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "INSERT INTO 	injoignable(identreprise, date, heure, numtel, nom, prenom, poste, reponse, note) VALUES (" + rap.IDENTREPRISE + ",'" + rap.DATE + "','" + rap.HEURE + "','" + rap.NUMTEL + "','" + rap.NOM + "','" + rap.PRENOM + "','" + rap.POSTE + "','" + rap.REPONSE + "','" + rap.NOTE + "')";
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
        #region ModifierRappelInjoignable()
        public static int ModifierRappelInjoignable(Injoignable rap, int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "UPDATE  injoignable SET identreprise =" + rap.IDENTREPRISE + ", date='" + rap.DATE + "', heure='" + rap.HEURE + "',numtel='" + rap.NUMTEL + "',nom='" + rap.NOM + "',prenom='" + rap.PRENOM + "',poste='" + rap.POSTE + "',reponse='" + rap.REPONSE + "',note='" + rap.NOTE + "'   WHERE id=" + idd + " ";
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
        #region SupprimerRappelInjoignable()
        public static int SupprimerRappelInjoignable(int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "DELETE FROM injoignable WHERE id=" + idd + " ";
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
