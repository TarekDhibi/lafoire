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
    class noninteresseC
    {
        public static List<noninteresse> GetAllrappelNoninteresse()
        {
            List<noninteresse> list = new List<noninteresse>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = "SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, note FROM 	noninteresse";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new noninteresse
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

        public static List<noninteresse> GetAllRappelNoninteressefiltre(String champ, String texte)
        {
            List<noninteresse> list = new List<noninteresse>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, note  FROM 	noninteresse WHERE " + champ + " like '%" + texte + "%'";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new noninteresse
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

        #region AjouterRappelNoninteresse()
        public static int AjouterRappelNoninteresse(noninteresse rap)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "INSERT INTO noninteresse(identreprise, date, heure, numtel, nom, prenom, poste, reponse, note) VALUES (" + rap.IDENTREPRISE + ",'" + rap.DATE + "','" + rap.HEURE + "','" + rap.NUMTEL + "','" + rap.NOM + "','" + rap.PRENOM + "','" + rap.POSTE + "','" + rap.REPONSE + "','" + rap.NOTE + "')";
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
        #region ModifierRappelNoninteresse()
        public static int ModifierRappelNoninteresse(noninteresse rap, int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "UPDATE noninteresse SET identreprise =" + rap.IDENTREPRISE + ", date='" + rap.DATE + "', heure='" + rap.HEURE + "',numtel='" + rap.NUMTEL + "',nom='" + rap.NOM + "',prenom='" + rap.PRENOM + "',poste='" + rap.POSTE + "',reponse='" + rap.REPONSE + "',note='" + rap.NOTE + "'   WHERE id=" + idd + " ";
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
        #region SupprimerRappelNoninteresse()
        public static int SupprimerRappelNoninteresse(int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "DELETE FROM fauxnumero WHERE id=" + idd + " ";
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
        #region ModifierEtatEntreprise()
        public static int ModifierEtatEntreprise(entreprise ent, int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string ch = "Rappels terminés";
                string req = "UPDATE  entreprise SET  etat='" + ch + "' WHERE id=" + idd + " ";
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
