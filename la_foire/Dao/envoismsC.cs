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
    class envoismsC
    {
        public static List<envoisms> GetAllrappelEnvoisms()
        {
            List<envoisms> list = new List<envoisms>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = "SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, tel1, note1, tel2, note2, etat, notegenerale FROM envoisms";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new envoisms
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

        public static List<envoisms> GetAllRappelEnvoismsfiltre(String champ, String texte)
        {
            List<envoisms> list = new List<envoisms>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT id, identreprise, date, heure, numtel, nom, prenom, poste, reponse, tel1, note1, tel2, note2, etat, notegenerale  FROM 	envoisms WHERE " + champ + " like '%" + texte + "%'";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new envoisms
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

        #region AjouterRappelEnvoisms()
        public static int AjouterRappelEnvoisms(envoisms rap)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "INSERT INTO envoisms(identreprise, date, heure, numtel, nom, prenom, poste, reponse, tel1, note1, tel2, note2, etat, notegenerale) VALUES (" + rap.IDENTREPRISE + ",'" + rap.DATE + "','" + rap.HEURE + "','" + rap.NUMTEL + "','" + rap.NOM + "','" + rap.PRENOM + "','" + rap.POSTE + "','" + rap.REPONSE + "','" + rap.TEL1 + "','" + rap.NOTE1 + "','" + rap.TEL2 + "','" + rap.NOTE2 + "','" + rap.ETAT + "','" + rap.NOTEGENERALE + "')";
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
        #region ModifierRappelEnvoisms()
        public static int ModifierRappelEnvoisms(envoisms rap, int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "UPDATE envoisms SET identreprise =" + rap.IDENTREPRISE + ", date='" + rap.DATE + "', heure='" + rap.HEURE + "',numtel='" + rap.NUMTEL + "',nom='" + rap.NOM + "',prenom='" + rap.PRENOM + "',poste='" + rap.POSTE + "',reponse='" + rap.REPONSE + "',tel1='" + rap.TEL1 + "',note1='" + rap.NOTE1 + "',tel2='" + rap.TEL2 + "',note2='" + rap.NOTE2 + "',etat='" + rap.ETAT + "',notegenerale='" + rap.NOTEGENERALE + "'   WHERE id=" + idd + " ";
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
        #region SupprimerRappelEnvoisms()
        public static int SupprimerRappelEnvoisms(int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "DELETE FROM envoisms WHERE id=" + idd + " ";
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
                string ch = "Rappels en cours";
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
