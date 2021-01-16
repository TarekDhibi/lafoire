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
    class envoiemailC
    {
        public static List<envoiemail> GetAllrappelEnvoiemail()
        {
            List<envoiemail> list = new List<envoiemail>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = "SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, mail1, note1, mail2, note2, etat, notegenerale FROM envoiemail";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new envoiemail
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
                        MAIL1 = dt.GetString(9),
                        NOTE1 = dt.GetString(10),
                        MAIL2 = dt.GetString(11),
                        NOTE2 = dt.GetString(12),
                        ETAT = dt.GetString(13),
                        NOTEGENERALE = dt.GetString(14)
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

        public static List<envoiemail> GetAllRappelEnvoiemailfiltre(String champ, String texte)
        {
            List<envoiemail> list = new List<envoiemail>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, mail1, note1, mail2, note2, etat, notegenerale  FROM 	envoiemail WHERE " + champ + " like '%" + texte + "%'";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new envoiemail
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
                        MAIL1 = dt.GetString(9),
                        NOTE1 = dt.GetString(10),
                        MAIL2 = dt.GetString(11),
                        NOTE2 = dt.GetString(12),
                        ETAT = dt.GetString(13),
                        NOTEGENERALE = dt.GetString(14)
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

        #region AjouterRappelEnvoiemail()
        public static int AjouterRappelEnvoiemail(envoiemail rap)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "INSERT INTO envoiemail(identreprise, date, heure, numtel, nom, prenom, poste, reponse, mail1, note1, mail2, note2, etat, notegenerale) VALUES (" + rap.IDENTREPRISE + ",'" + rap.DATE + "','" + rap.HEURE + "','" + rap.NUMTEL + "','" + rap.NOM + "','" + rap.PRENOM + "','" + rap.POSTE + "','" + rap.REPONSE + "','" + rap.MAIL1 + "','" + rap.NOTE1 + "','" + rap.MAIL2 + "','" + rap.NOTE2 + "','" + rap.ETAT + "','" + rap.NOTEGENERALE + "')";
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
        #region ModifierRappelEnvoiemail()
        public static int ModifierRappelEnvoiemail(envoiemail rap, int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "UPDATE envoiemail SET identreprise =" + rap.IDENTREPRISE + ", date='" + rap.DATE + "', heure='" + rap.HEURE + "',numtel='" + rap.NUMTEL + "',nom='" + rap.NOM + "',prenom='" + rap.PRENOM + "',poste='" + rap.POSTE + "',reponse='" + rap.REPONSE + "',mail1='" + rap.MAIL1 + "',note1='" + rap.NOTE1 + "',mail2='" + rap.MAIL2 + "',note2='" + rap.NOTE2 + "',etat='" + rap.ETAT + "',notegenerale='" + rap.NOTEGENERALE + "'   WHERE id=" + idd + " ";
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
        #region SupprimerRappelEnvoiemail()
        public static int SupprimerRappelEnvoiemail(int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "DELETE FROM envoiemail WHERE id=" + idd + " ";
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
