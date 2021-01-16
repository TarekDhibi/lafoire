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
    class entrepriseC
    {

        public static List<entreprise> GetAllEntreprise()
        {
            List<entreprise> list = new List<entreprise>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = "SELECT id, nom, cat, scat, governorat, delegation, etat, localite, nomg, prenomg, adresse, telg1, telg2, telg3, telen1, telen2, telen3, mailg1, mailg2, mailg3, mailen1, mailen2, mailen3, source, web FROM entreprise";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new entreprise
                    {

                        ID = dt.GetInt16(0),
                        NOM = dt.GetString(1),
                        CAT = dt.GetString(2),
                        SCAT = dt.GetString(3),
                        GOVERNORAT = dt.GetString(4),
                        DELEGATION = dt.GetString(5),
                        ETAT = dt.GetString(6),
                        LOCALITE = dt.GetString(7),
                        NOMG = dt.GetString(8),
                        PRENOMG = dt.GetString(9),
                        ADRESSE = dt.GetString(10),
                        TELG1 = dt.GetString(11),
                        TELG2 = dt.GetString(12),
                        TELG3 = dt.GetString(13),       
                        TELEN1 = dt.GetString(14),
                        TELEN2 = dt.GetString(15),
                        TELEN3 = dt.GetString(16),
                        MAILG1 = dt.GetString(17),
                        MAILG2 = dt.GetString(18),
                        MAILG3 = dt.GetString(19),
                        MAILEN1 = dt.GetString(20),
                        MAILEN2 = dt.GetString(21),
                        MAILEN3 = dt.GetString(22),
                        SOURCE = dt.GetString(23),
                        WEB = dt.GetString(24)
                    });
                }
                con.CloseConnection();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+"azerty" );
                return null;
            }
        }

        public static List<entreprise> GetAllentreprisefiltre(String champ, String texte)
        {
            List<entreprise> list = new List<entreprise>();
            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();
                string req = " SELECT id, nom, cat, scat, governorat, delegation, etat, localite, nomg, prenomg, adresse, telg1, telg2, telg3, telen1, telen2, telen3, mailg1, mailg2, mailg3, mailen1, mailen2, mailen3, source, web FROM entreprise WHERE " + champ + " like '%" + texte + "%'";
                MySqlCommand cmd = new MySqlCommand(req, con.connexion);
                MySqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    list.Add(new entreprise
                    {


                        ID = dt.GetInt16(0),
                        NOM = dt.GetString(1),
                        CAT = dt.GetString(2),
                        SCAT = dt.GetString(3),
                        GOVERNORAT = dt.GetString(4),
                        DELEGATION = dt.GetString(5),
                        ETAT = dt.GetString(6),
                        LOCALITE = dt.GetString(7),
                        NOMG = dt.GetString(8),
                        PRENOMG = dt.GetString(9),
                        ADRESSE = dt.GetString(10),
                        TELG1 = dt.GetString(11),
                        TELG2 = dt.GetString(12),
                        TELG3 = dt.GetString(13),
                        TELEN1 = dt.GetString(14),
                        TELEN2 = dt.GetString(15),
                        TELEN3 = dt.GetString(16),
                        MAILG1 = dt.GetString(17),
                        MAILG2 = dt.GetString(18),
                        MAILG3 = dt.GetString(19),
                        MAILEN1 = dt.GetString(20),
                        MAILEN2 = dt.GetString(21),
                        MAILEN3 = dt.GetString(22),
                        SOURCE = dt.GetString(23),
                        WEB = dt.GetString(24)
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

        #region AjouterEntreprise()
        public static int AjouterEntreprise(entreprise ent)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "INSERT INTO entreprise(nom,cat,scat,governorat,delegation,etat,localite,nomg,prenomg,adresse,telg1,telg2,telg3,telen1,telen2,telen3,mailg1,mailg2,mailg3,mailen1,mailen2,mailen3,source,web) VALUES ('" + ent.NOM + "','" + ent.CAT + "','" + ent.SCAT + "','" + ent.GOVERNORAT + "','" + ent.DELEGATION + "','" + ent.ETAT + "','" + ent.LOCALITE + "','" + ent.NOMG + "','" + ent.PRENOMG + "','" + ent.ADRESSE + "','" + ent.TELG1 + "','" + ent.TELG2 + "','" + ent.TELG3 + "','" + ent.TELEN1 + "','" + ent.TELEN2 + "','" + ent.TELEN3 + "','" + ent.MAILG1 + "','" + ent.MAILG2 + "','" + ent.MAILG3 + "','" + ent.MAILEN1 + "','" + ent.MAILEN2 + "','" + ent.MAILEN3 + "','" + ent.SOURCE + "','" + ent.WEB + "')";
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
        #region ModifierEntreprise()
        public static int ModifierEntreprise(entreprise ent,int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "UPDATE  entreprise SET nom ='" + ent.NOM + "', cat='" + ent.CAT + "', scat='" + ent.SCAT + "',governorat='" + ent.GOVERNORAT + "',delegation='" + ent.DELEGATION + "',etat='" + ent.ETAT + "',localite='" + ent.LOCALITE + "',nomg='" + ent.NOMG + "',prenomg='" + ent.PRENOMG + "',adresse='" + ent.ADRESSE + "',telg1='" + ent.TELG1 + "',telg2='" + ent.TELG2 + "',telg3='" + ent.TELG3 + "',telg3='" + ent.TELG3 + "',telen2='" + ent.TELEN2 + "',telen3='" + ent.TELEN3 + "',mailg1='" + ent.MAILG1 + "',mailg2='" + ent.MAILG2 + "',mailg3='" + ent.MAILG3 + "',mailen1='" + ent.MAILEN1 + "',mailen2='" + ent.MAILEN2 + "',mailen3='" + ent.MAILEN3 + "',source='" + ent.SOURCE + "',web='" + ent.WEB + "' WHERE id=" + idd + " ";
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
        #region SupprimerEntreprise()
        public static int SupprimerEntreprise(int idd)
        {

            try
            {
                Connexion con = new Connexion();
                con.OpenConnection();

                string req = "DELETE FROM entreprise WHERE id=" + idd + " ";
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
