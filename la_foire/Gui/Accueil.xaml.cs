using la_foire.Dao;
using la_foire.Ent;
using la_foire.Tech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace la_foire.Gui
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        profile admin = new profile();
        entreprise ent =new entreprise();
        private String ActionDemander = "";
        private Boolean actionRech = false;
        int idAdminCourant = 0;
        List<categorie> ls = new List<categorie>();
        List<souscategorie> ls1 = new List<souscategorie>();
        List<gouvernorat> ls2 = new List<gouvernorat>();
        List<delegation> ls3 = new List<delegation>();

        List<String> lN = new List<String>();
        List<String> lN1 = new List<String>();

        public Accueil()
        {
            InitializeComponent();
            LoadAllProfiles();





        }
        public Accueil(int id, String adminn)
        {

            InitializeComponent();
             LoadAllCategories();
            this.idAdminCourant = id;
            creerTitre();
            this.admin = la_foire.Dao.profilC.GetProfileFromLogin(adminn);
            LoadAllProfiles();
            actionRech = true;
            LoadAllGouvernorat();
            TBdaterap.Text = DateTime.Now.ToString("MM\\/dd\\/yyyy");
            TBdheurerap.Text = DateTime.Now.ToString("HH:mm");
            

            TBEtatrappel.Items.Add("Injoignable");
            TBEtatrappel.Items.Add("Faux numéro");
            TBEtatrappel.Items.Add("Non intéressé");
            TBEtatrappel.Items.Add("Envoie mail");
            TBEtatrappel.Items.Add("Envoie sms");
            TBEtatrappel.Items.Add("A rappeler");
            TBEtatrappel.Items.Add("Rendez-vous");

            privilege();
        }

        private void privilege()
        {
            String role = profilC.GetRole(idAdminCourant);
           
            if (role.Equals("Assistant"))
            {
                histo.IsEnabled = false;
                 GestionAdmin2.Visibility = Visibility.Hidden;
                 BtModifierentreprise.Visibility = Visibility.Hidden;
                 BtSupprimerentreprise.Visibility = Visibility.Hidden;
                 BtModifierrappel.Visibility = Visibility.Hidden;
                 BtSupprimerrappel.Visibility = Visibility.Hidden;

            }
            if (role.Equals("Agent de saisie"))
            {
                histo.IsEnabled = false;
                GestionRappels.Visibility = Visibility.Hidden;
                GestionAdmin2.Visibility = Visibility.Hidden;
                BtModifierentreprise.Visibility = Visibility.Hidden;
                BtSupprimerentreprise.Visibility = Visibility.Hidden;
            }
            if (role.Equals("Utilisateur"))
            {
                histo.IsEnabled = false;
                 GestionAdmin2.Visibility = Visibility.Hidden;

                BtAjouterentreprise.Visibility = Visibility.Hidden;
                BtModifierentreprise.Visibility = Visibility.Hidden;
                BtSupprimerentreprise.Visibility = Visibility.Hidden;
                BtModifierrappel.Visibility = Visibility.Hidden;
                BtSupprimerrappel.Visibility = Visibility.Hidden;
                BtAjouterrapel.Visibility = Visibility.Hidden;
            }
        }
        private void creerTitre()
        {
            try
            {
                String login = Dao.profilC.GetLoginFromId(idAdminCourant);

                this.Title = "www.la-foire.com | Utilisateur courant : " + login;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MIDV_Click(object sender, RoutedEventArgs e)
        {
            Apropos a = new Apropos();
            a.Show();
        }
        private void MIDeconnexion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            for (int i = Application.Current.Windows.Count - 1; i >= 0; i--)
            {
                if (Application.Current.Windows[i].Name != "authen")
                    Application.Current.Windows[i].Close();
            }

        }
        private void MIQuitter_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);

        }
        private void MenuItem_Click_26(object sender, RoutedEventArgs e)
        {
            Journal j = new Journal();
            j.Show();

        }


        #region Gestion admin
        private void AfficherMsgErreur(String msg)
        {
            Msg.Visibility = Visibility.Visible;
            Msg.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff6666"));
            Msg.Content = msg;
        }

        private void AfficherMsgConfirmation(String msg)
        {
            Msg.Visibility = Visibility.Visible;
            Msg.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#32CD32"));
            Msg.Content = msg;
        }
        private void AfficherMsgInfo(String msg)
        {
            Msg.Visibility = Visibility.Visible;
            Msg.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E90FF"));
            Msg.Content = msg;
        }

        private void Afficher_Msg_Erreur(String msg)
        {
            Msgen.Visibility = Visibility.Visible;
            Msgen.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff6666"));
            Msgen.Content = msg;
        }

        private void Afficher_Msg_Confirmation(String msg)
        {
            Msgen.Visibility = Visibility.Visible;
            Msgen.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#32CD32"));
            Msgen.Content = msg;
        }
        private void Afficher_Msg_Info(String msg)
        {
            Msgen.Visibility = Visibility.Visible;
            Msgen.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E90FF"));
            Msgen.Content = msg;
        }

        private void cacherGroupeA()
        {
            BtAjouter.Visibility = Visibility.Hidden;
            BtModifier.Visibility = Visibility.Hidden;
            BtSupprimer.Visibility = Visibility.Hidden;
            BtConfirmer.Visibility = Visibility.Visible;
            BtAnnuler.Visibility = Visibility.Visible;
        }

        private void cacherGroupeB()
        {
            BtAjouter.Visibility = Visibility.Visible;
            BtModifier.Visibility = Visibility.Visible;
            BtSupprimer.Visibility = Visibility.Visible;
            BtConfirmer.Visibility = Visibility.Hidden;
            BtAnnuler.Visibility = Visibility.Hidden;
        }

        private void cacherGroupeenA()
        {
            BtAjouterentreprise.Visibility = Visibility.Hidden;
            BtModifierentreprise.Visibility = Visibility.Hidden;
            BtSupprimerentreprise.Visibility = Visibility.Hidden;
            BtConfirmerentreprise.Visibility = Visibility.Visible;
            BtAnnulerentreprise.Visibility = Visibility.Visible;
        }


        private void cacherGroupeenB()
        {
            BtAjouterentreprise.Visibility = Visibility.Visible;
            BtModifierentreprise.Visibility = Visibility.Visible;
            BtSupprimerentreprise.Visibility = Visibility.Visible;
            BtConfirmerentreprise.Visibility = Visibility.Hidden;
            BtAnnulerentreprise.Visibility = Visibility.Hidden;
        }

        private Boolean champsVide()
        {
            if (TBLogin.Text.Equals("") || TBMail.Text.Equals("") || TBMotdePasse.Text.Equals(""))
            {
                return true;
            }
            return false;
        }


        private void BtAnnuler_MouseEnter(object sender, MouseEventArgs e)
        {
            BtAnnuler.Opacity = 1;
        }

        private void enterMouse(object sender, MouseEventArgs e)
        {
            //Button button = (Button)e.OriginalSource;
            (sender as Button).Opacity = 1;
        }

        private void leaveMouse(object sender, MouseEventArgs e)
        {
            //Button button = (Button)e.OriginalSource;
            (sender as Button).Opacity = 0.5;
        }

        private void BtAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (champsVide())
            {
                AfficherMsgErreur("Erreur : champ(s) vide(s)");
            }
            else
            {
                ActionDemander = "Ajout";
                cacherGroupeA();
            }
        }

        private void BtModifier_Click(object sender, RoutedEventArgs e)
        {
            if (champsVide())
            {
                AfficherMsgErreur("Erreur : champ(s) vide(s)");
            }
            else
            {
                ActionDemander = "Modifier";
                cacherGroupeA();
            }
        }

        private void BtSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (TBId.Text.Equals(""))
            {
                AfficherMsgErreur("Erreur : Vous devez selectionner un administrateur");
            }
            else
            {
                ActionDemander = "Supprimer";
                cacherGroupeA();
            }
        }

 bool IsValidEmail(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        
        private void BtConfirmer_Click(object sender, RoutedEventArgs e)
        {
            //ActionDemander = "";
            if (champsVide())
            {
                AfficherMsgErreur("Erreur : champ(s) vide(s)");
            }
                            else {
                if(!IsValidEmail(TBMail.Text)){
                    AfficherMsgErreur("Erreur : E-mail invalide");


                }
            else
            {
                String solId;
                if (TBId.Text.Equals(""))
                {
                    solId = "0";
                }
                else
                {
                    solId = TBId.Text;
                }
                profile adminx = new profile(Int16.Parse(solId), TBLogin.Text, TBMotdePasse.Text, TBMail.Text, TBRole.Text, CHEtat.IsChecked.Value);
                //MessageBox.Show(" "+CHEtat.IsChecked.Value);
                if (ActionDemander.Equals("Ajout"))
                {
                    int c = la_foire.Dao.profilC.LogExiste(TBLogin.Text);
                    if (c == -1)
                    {
                        AfficherMsgErreur("Erreur de connexion à la base de données");
                    }
                    else
                    {
                        if (c == 0)
                        {
                            int res = la_foire.Dao.profilC.AjouterProfile(adminx);
                            if (res == 1)
                            {
                                AfficherMsgConfirmation("L'administrateur est bien ajouter");

                            }
                            else
                            {
                                AfficherMsgErreur("Erreur de connexion à la base de données");
                            }
                        }
                        else
                        {
                            AfficherMsgErreur("Ce login est déja utilisé.");
                        }
                    }
                    cacherGroupeB();
                    LoadAllProfiles();
                }
                else
                {
                    if (ActionDemander.Equals("Modifier"))
                    {
                        if (!TBId.Text.Equals(""))
                        {
                            if (la_foire.Dao.profilC.LogExiste(TBLogin.Text, Int16.Parse(TBId.Text)) == -1)
                            {
                                AfficherMsgErreur("Erreur de connexion à la base de données");
                            }
                            else
                            {
                                if (la_foire.Dao.profilC.LogExiste(TBLogin.Text, Int16.Parse(TBId.Text)) != 0)
                                {
                                    AfficherMsgErreur("Ce login est déja utilisé.");
                                }
                                else
                                {
                                    int res = la_foire.Dao.profilC.ModifierProfile(adminx);
                                    if (res == 1)
                                    {
                                        AfficherMsgConfirmation("L'administrateur est bien modifier");
                                    }
                                    else
                                    {
                                        AfficherMsgErreur("Erreur de connexion à la base de données");
                                    }
                                }

                            }

                        }
                        cacherGroupeB();
                        LoadAllProfiles();
                    }
                    else
                    {
                        if (ActionDemander.Equals("Supprimer"))
                        {
                            if (!TBId.Text.Equals(""))
                            {
                                if (profilC.IdExisteJournal(Int16.Parse(TBId.Text)) == -1)
                                {
                                    AfficherMsgErreur("Erreur de connexion à la base de données");
                                }

                                else
                                {
                                    int res = profilC.SupprimerProfile(adminx.ID);
                                    if (res == 1)
                                    {
                                        AfficherMsgConfirmation("Le profil est bien supprimer");
                                    }
                                    else
                                    {
                                        AfficherMsgErreur("Erreur de connexion à la base de données");
                                    }
                                }
                            }

                            else
                            {
                                AfficherMsgErreur("Veuillez sélctionnez un Adminitrateur");
                            }
                        }
                    }



                }

            }
            cacherGroupeB();
            LoadAllProfiles();

                            }
        }


        private void BtAnnuler_Click(object sender, RoutedEventArgs e)
        {
            ActionDemander = "";
            cacherGroupeB();
        }

        private void BtAjouter_MouseEnter(object sender, MouseEventArgs e)
        {
            BtAjouter.Opacity = 1;
            AfficherMsgInfo("Ajouter un nouvel Administrateur");
        }

        private void BtAjouter_MouseLeave(object sender, MouseEventArgs e)
        {
            BtAjouter.Opacity = 0.5;
        }

        private void BtModifier_MouseEnter(object sender, MouseEventArgs e)
        {
            BtModifier.Opacity = 1;
            AfficherMsgInfo("Modifier l'administrateur courant");
        }

        private void BtModifier_MouseLeave(object sender, MouseEventArgs e)
        {
            BtModifier.Opacity = 0.5;
        }

        private void BtSupprimer_MouseEnter(object sender, MouseEventArgs e)
        {
            BtSupprimer.Opacity = 1;
            AfficherMsgInfo("Supprimer l'administrateur courant ");
        }

        private void BtSupprimer_MouseLeave(object sender, MouseEventArgs e)
        {
            BtSupprimer.Opacity = 0.5;
        }

        private void BtConfirmer_MouseEnter(object sender, MouseEventArgs e)
        {
            BtConfirmer.Opacity = 1;
        }

        private void BtConfirmer_MouseLeave(object sender, MouseEventArgs e)
        {
            BtConfirmer.Opacity = 0.5;
        }

        private void BtAnnuler_MouseLeave(object sender, MouseEventArgs e)
        {
            BtAnnuler.Opacity = 0.5;
        }

        private void LoadAllProfiles()
        {
            List<la_foire.Ent.profile> reader = la_foire.Dao.profilC.GetAllProfiles();
            DataGridAdmin.ItemsSource = null;
            DataGridAdmin.ItemsSource = reader;

        }
        private void loadAllAdmin(String colonne, String ch)
        {
            List<la_foire.Ent.profile> reader = la_foire.Dao.profilC.GetAllProfilesLikeColonne(colonne, ch);
            DataGridAdmin.ItemsSource = null;
            DataGridAdmin.ItemsSource = reader;
        }
        private void DataGridAdmin_MouseUp(object sender, MouseButtonEventArgs e)
        {
            object item = DataGridAdmin.SelectedItem;
            try
            {
                TBId.Text = (DataGridAdmin.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                TBLogin.Text = (DataGridAdmin.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                TBMotdePasse.Text = (DataGridAdmin.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                TBMail.Text = (DataGridAdmin.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                String s = (DataGridAdmin.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                switch (s)
                {
                    case "Administrateur": TBRole.SelectedIndex = 0; break;
                    case "Assistant": TBRole.SelectedIndex = 1; break;
                    case "Agent de saisie": TBRole.SelectedIndex = 1; break;
                    case "Utilistateur": TBRole.SelectedIndex = 2; break;
                }
                CHEtat.IsChecked = (DataGridAdmin.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text.Equals("True");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }

        private void TBFiltre_KeyUp(object sender, KeyEventArgs e)
        {
            if (TBFiltre.Text.Equals(""))
            {
                LoadAllProfiles();
            }
            else
            {
                switch (CBFiltresa.SelectedIndex)
                {
                    case 0: loadAllAdmin("login", TBFiltre.Text); break;
                    case 1: loadAllAdmin("mail", TBFiltre.Text); break;
                    case 2: loadAllAdmin("role", TBFiltre.Text); break;
                    case 3: loadAllAdmin("etat", TBFiltre.Text); break;
                }
            }
        }

        private void CBFiltres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (actionRech)
            {
                switch (CBFiltresa.SelectedIndex)
                {
                    case 0: AfficherMsgInfo("Veuillez saisir un ou plusieur caractères du login."); break;
                    case 1: AfficherMsgInfo("Veuillez saisir un ou plusieur caractères du mail."); break;
                    case 2: AfficherMsgInfo("Veuillez saisir un ou plusieur caractères du role."); break;
                    case 3: AfficherMsgInfo("Veuillez saisir 1 pour l'état actif 0 sinon."); break;
                }
            }
        }

        private void Msg_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Msg.Visibility = Visibility.Hidden;
        }
        #endregion

        private void LoadAllCategories()
        {
            ls.Clear();
            ls = la_foire.Dao.categorieC.GetAllCat();
            lN.Clear();
            for (int i = 0; i < ls.Count; i++)
            {
                lN.Add(ls.ElementAt(i).NOM);
            }
            CBCat.Items.Clear();
            for (int i = 0; i < lN.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = lN.ElementAt(i);
                item.Value = i;
                CBCat.Items.Add(item);

                CBCat.SelectedIndex = 0;

            }
        }

        private void CBCat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            TBIdcat.Text = CBCat.SelectedItem + "";
            ls1.Clear();
            ls1 = la_foire.Dao.souscategorieC.GetSousCat(ls.ElementAt(CBCat.SelectedIndex).ID);
            lN1.Clear();
            for (int i = 0; i < ls1.Count; i++)
            {
                lN1.Add(ls1.ElementAt(i).NOM);
            }
            CBSCat.Items.Clear();
            for (int i = 0; i < lN1.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = lN1.ElementAt(i);
                item.Value = i;
                CBSCat.Items.Add(item);

                CBSCat.SelectedIndex = 0;

            }
            TBIdcat.Text = CBCat.SelectedItem + "";
            TBIdscat.Text = CBSCat.SelectedItem + "";
        }


        private void CBSCat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TBIdscat.Text = CBSCat.SelectedItem + "";
        }

        private void afficherentreprises_Click(object sender, RoutedEventArgs e)
        {
            AfficherEntreprise afen = new AfficherEntreprise();

            afen.Show();
        }
        private void LoadAllGouvernorat()
        {
            ls2.Clear();
            ls2 = la_foire.Dao.gouvernoratC.GetAllGouv();
            lN.Clear();
            for (int i = 0; i < ls2.Count; i++)
            {
                lN.Add(ls2.ElementAt(i).NOM);
            }
            CBGouv.Items.Clear();
            for (int i = 0; i < lN.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = lN.ElementAt(i);
                item.Value = i;
                CBGouv.Items.Add(item);

                CBGouv.SelectedIndex = 0;

            }
        }

        private void CBGouv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TBGouv.Text = CBGouv.SelectedItem + "";
            ls3.Clear();
            ls3 = la_foire.Dao.DelegationC.GetDel(ls2.ElementAt(CBGouv.SelectedIndex).ID);
            lN1.Clear();
            for (int i = 0; i < ls3.Count; i++)
            {
                lN1.Add(ls3.ElementAt(i).NOM);
            }
            CBDel.Items.Clear();
            for (int i = 0; i < lN1.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = lN1.ElementAt(i);
                item.Value = i;
                CBDel.Items.Add(item);

                CBDel.SelectedIndex = 0;

            }
            TBGouv.Text = CBGouv.SelectedItem + "";
            TBDel.Text = CBDel.SelectedItem + "";
          
        }

        private void CBDel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TBDel.Text = CBDel.SelectedItem + "";

        }

        private void Msgen_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Msgen.Visibility = Visibility.Hidden;

        }

        private void BtAjouterentreprise_MouseEnter(object sender, MouseEventArgs e)
        {
            BtAjouterentreprise.Opacity = 1;
            Afficher_Msg_Info("Ajouter une entreprise ");
                

        }

        private void BtAjoutererentreprise_MouseLeave(object sender, MouseEventArgs e)
        {
            BtAjouterentreprise.Opacity = 0.5;
        }

        private void BtModifiererentreprise_MouseEnter(object sender, MouseEventArgs e)
        {
            BtModifierentreprise.Opacity = 1;
            Afficher_Msg_Info("Modifier l'entreprise courant ");

        }

        private void BtModifiererentreprise_MouseLeave(object sender, MouseEventArgs e)
        {
            BtModifierentreprise.Opacity =0.5;
        }

        private void BtSupprimererentreprise_MouseEnter(object sender, MouseEventArgs e)
        {
            BtSupprimerentreprise.Opacity = 1;
            Afficher_Msg_Info("Supprimer l'entreprise courant ");
        }

        private void BtSupprimererentreprise_MouseLeave(object sender, MouseEventArgs e)
        {
            BtSupprimerentreprise.Opacity = 0.5;
        }

        private void BtAjoutererentreprise_Click(object sender, RoutedEventArgs e)
        {
            if (champsVideEntreprise())
            {
                Afficher_Msg_Erreur("Erreur : champ(s) vide(s)");
            }
            else
            {
                ActionDemander = "Ajout";
                cacherGroupeenA();
            }
        }

        private void BtModifiererentreprise_Click(object sender, RoutedEventArgs e)
        {
            if (champsVideEntreprise())
            {


                Afficher_Msg_Erreur("Erreur : Vous devez selectionner une entreprise");
            }
            else
            {
                ActionDemander = "Modifier";
                cacherGroupeenA();
            }
        }

        private void BtSupprimererentreprise_Click(object sender, RoutedEventArgs e)
        {
            if (champsVideEntreprise())
            {
                Afficher_Msg_Erreur("Erreur : Vous devez selectionner une entreprise");
            }
            else
            {
                ActionDemander = "Supprimer";
                cacherGroupeenA();
            }
        }

        private Boolean champsVideEntreprise()
        {
            if (TBNom.Text.Equals("")  || TBTelen1.Text.Equals("")    )
            {
                return true;
            }
            return false;
        }

        private void BtAnnulerentreprise_Click(object sender, RoutedEventArgs e)
        {
            ActionDemander = "";
            cacherGroupeenB();
        }

        private void BtConfirmerentreprise_MouseEnter(object sender, MouseEventArgs e)
        {
            BtConfirmerentreprise.Opacity = 1;
        }

        private void BtConfirmerentreprise_MouseLeave(object sender, MouseEventArgs e)
        {
            BtConfirmerentreprise.Opacity =0.5;
        }

        private void BtAnnulerentreprise_MouseEnter(object sender, MouseEventArgs e)
        {
            BtAnnulerentreprise.Opacity = 1;
        }

        private void BtAnnulerentreprise_MouseLeave(object sender, MouseEventArgs e)
        {
            BtAnnulerentreprise.Opacity =0.5;
        }

        private void BtConfirmerentreprise_Click(object sender, RoutedEventArgs e)
        {
            {
                //ActionDemander = "";
                if (champsVideEntreprise())
                {
                    Afficher_Msg_Erreur("Erreur : champ(s) vide(s)");
                }
            
                    else
                    {
                        String solId;
                        if (TBIden.Text.Equals(""))
                        {
                            solId = "0";
                        }
                        else
                        {
                            solId = TBIden.Text;
                        }
                        entreprise ent = new entreprise(Int16.Parse(solId), TBNom.Text, TBIdcat.Text, TBIdscat.Text, TBGouv.Text, TBDel.Text, TBEtat.Text,TBLoca.Text, TBNomg1.Text, TBPrenom.Text, TBAdresse.Text, TBTelg1.Text, TBTelg2.Text, TBTelg3.Text, TBTelen1.Text, TBTelen2.Text, TBTelen2.Text, TBmailg1.Text, TBmailg2.Text, TBmailg3.Text, TBmailen1.Text, TBmailen2.Text, TBmailen3.Text, TBsource.Text, TBlienweb.Text);
                        //MessageBox.Show(" "+CHEtat.IsChecked.Value);
                        if (ActionDemander.Equals("Ajout"))
                        {
                            
                                
                                    int res = la_foire.Dao.entrepriseC.AjouterEntreprise(ent);
                                    if (res == 1)
                                    {
                                        Afficher_Msg_Confirmation("L'entreprise est bien ajouter");
                                        cacherGroupeenB();

                                    }
                                    else
                                    {
                                        Afficher_Msg_Erreur("Erreur de connexion à la base de données");
                                        cacherGroupeenB();
                                    }



                                    cacherGroupeenB();
                                    ViderChanpsEntreprise();
                                    
                          }  
                  
                        else
                        {
                            if (ActionDemander.Equals("Modifier"))
                            {
                                if (!TBIden.Text.Equals(""))
                                {

                                    int idden = Int16.Parse(TBIden.Text);
                                    int res = la_foire.Dao.entrepriseC.ModifierEntreprise(ent, idden);
                                            if (res == 1)
                                            {
                                                Afficher_Msg_Confirmation("L'entreprise est bien modifier");
                                                cacherGroupeenB();
                                            }
                                            else
                                            {
                                                Afficher_Msg_Erreur("Erreur de connexion à la base de données");
                                                cacherGroupeenB();
                                            }

 
                         
                                            cacherGroupeenB();
                                            ViderChanpsEntreprise();

                                }

                            }
                            else
                            {
                                if (ActionDemander.Equals("Supprimer"))
                                {
                                    if (!TBIden.Text.Equals(""))
                                    {
                                        int idden = Int16.Parse(TBIden.Text);
                                        int res = entrepriseC.SupprimerEntreprise(idden);
                                            if (res == 1)
                                            {
                                                Afficher_Msg_Confirmation("L'entreprise est bien supprimer");
                                                cacherGroupeenB();
                                            }
                                            else
                                            {
                                                Afficher_Msg_Erreur("Erreur de connexion à la base de données");
                                                cacherGroupeenB();
                                            }
                                 }

                                    else
                                    {
                                        Afficher_Msg_Erreur("Veuillez sélctionnez une Entreprise");
                                        cacherGroupeenB();
                                    }
                                }
                            }



                        }

                    }
                cacherGroupeenB();
                ViderChanpsEntreprise();
                     

                 
            }
        }


        private void ViderChanpsEntreprise()
        {

            TBIden.Text = "";
            TBNom.Text = "";
            TBIdcat.Text = "";
            TBIdscat.Text = "";
            TBGouv.Text = "";
            TBDel.Text = "";
            TBLoca.Text = "";
            TBNomg1.Text = "";
            TBPrenom.Text = "";
            TBAdresse.Text = "";
            TBTelg1.Text = "";
            TBTelg2.Text = "";
            TBTelg3.Text = "";
            TBTelen1.Text = "";
            TBTelen2.Text = "";
            TBTelen3.Text = "";
            TBmailg1.Text = "";
            TBmailg2.Text = "";
            TBmailg3.Text = "";
            TBmailen1.Text = "";
            TBmailen2.Text = "";
            TBmailen3.Text = "";
            TBsource.Text = "";
            TBlienweb.Text = "";

        }

        private void btviderchamps_Click(object sender, RoutedEventArgs e)
        {
            ViderChanpsEntreprise();
        }

        private void cacherGroupeenAA()
        {
            BtAjouterrapel.Visibility = Visibility.Hidden;
            BtModifierrappel.Visibility = Visibility.Hidden;
            BtSupprimerrappel.Visibility = Visibility.Hidden;
            BtConfirmerrappel.Visibility = Visibility.Visible;
            BtAnnulerrappel.Visibility = Visibility.Visible;
        }


        private void cacherGroupeenBB()
        {
            BtAjouterrapel.Visibility = Visibility.Visible;
            BtModifierrappel.Visibility = Visibility.Visible;
            BtSupprimerrappel.Visibility = Visibility.Visible;
            BtConfirmerrappel.Visibility = Visibility.Hidden;
            BtAnnulerrappel.Visibility = Visibility.Hidden;
        }

        private void Afficher_Msg_Erreur_rappel(String msg)
        {
            Msgrappel.Visibility = Visibility.Visible;
            Msgrappel.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff6666"));
            Msgrappel.Content = msg;
        }

        private void Afficher_Msg_Confirmation_rappel(String msg)
        {
            Msgrappel.Visibility = Visibility.Visible;
            Msgrappel.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#32CD32"));
            Msgrappel.Content = msg;
        }
        private void Afficher_Msg_Info_rappel(String msg)
        {
            Msgrappel.Visibility = Visibility.Visible;
            Msgrappel.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E90FF"));
            Msgrappel.Content = msg;
        }
        private void TBEtatrappel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (TBEtatrappel.SelectedValue.ToString() == "Injoignable")
            {

                

                TBnoteraping.Visibility = Visibility.Visible;
                labelnoteinj.Visibility = Visibility.Visible;

                TBnoterapfauxnum.Visibility = Visibility.Hidden;
                TBnoterapnoninter.Visibility = Visibility.Hidden;

                HideNEnvoieEmail();
                HideEnvoieSms();
                HideARappeler();
                HideRDV();

            }
            else
            {

                if (TBEtatrappel.SelectedValue.ToString() == "Faux numéro")
                {

                    TBnoterapfauxnum.Visibility = Visibility.Visible;
                    labelnoteinj.Visibility = Visibility.Visible;

                    TBnoterapnoninter.Visibility = Visibility.Hidden;
                    TBnoteraping.Visibility = Visibility.Hidden;

                    HideNEnvoieEmail();
                    HideEnvoieSms();
                    HideARappeler();
                }

               
                    if (TBEtatrappel.SelectedValue.ToString() == "Non intéressé")
                    {

                        TBnoterapnoninter.Visibility = Visibility.Visible;
                        labelnoteinj.Visibility = Visibility.Visible;

                        TBnoteraping.Visibility = Visibility.Hidden;
                        TBnoterapfauxnum.Visibility = Visibility.Hidden;

                   
                        HideNEnvoieEmail();
                        HideEnvoieSms();
                        HideARappeler();
                        HideRDV();
                    }
                    {

                        if (TBEtatrappel.SelectedItem.ToString() =="Envoie mail")
                        {

                            TBmail1rapenv.Visibility = Visibility.Visible;
                            TBnotemail1rapenv.Visibility = Visibility.Visible;
                            TBmail2rapenv.Visibility = Visibility.Visible;
                            TBnotemail2rapenv.Visibility = Visibility.Visible;
                            TBnotegeneralerapenv.Visibility = Visibility.Visible;
                            CBEtatenvmail.Visibility = Visibility.Visible;

                            labelmail1env.Visibility = Visibility.Visible;
                            labelnotenotemail1env.Visibility = Visibility.Visible;
                            labelmail2env.Visibility = Visibility.Visible;
                            labelnotenotemail2env.Visibility = Visibility.Visible;
                            labeletatenv.Visibility = Visibility.Visible;
                            labelnotegeneralenv.Visibility = Visibility.Visible;

                            HideInjoigniable();
                            HideFauxnum();
                            HideNoninter();
                            HideEnvoieSms();
                            HideARappeler();
                            HideRDV();

                        }

                        if (TBEtatrappel.SelectedItem.ToString() == "Envoie sms")
                        {

                            TBtel1rapsms.Visibility = Visibility.Visible;
                            TBnottel1rapsms.Visibility = Visibility.Visible;
                            TBtel2rapsms.Visibility = Visibility.Visible;
                            TBnotetel2rapsms.Visibility = Visibility.Visible;
                            CBEtatenvsms.Visibility = Visibility.Visible;
                            TBnotegeneralerapsms.Visibility = Visibility.Visible;
                            labelnotegeneralsms.Visibility = Visibility.Visible;
                            labeletatsms.Visibility = Visibility.Visible;
                            labeltel1sms.Visibility = Visibility.Visible;
                            labeltel2sms.Visibility = Visibility.Visible;
                            labelnotenotetel2sms.Visibility = Visibility.Visible;
                            labelnotenottel1sms.Visibility = Visibility.Visible;

                            HideInjoigniable();
                            HideFauxnum();
                            HideNoninter();
                            HideNEnvoieEmail();
                            HideARappeler();
                            HideRDV();
                        }


                        if (TBEtatrappel.SelectedItem.ToString() == "A rappeler")
                        {
                            labelprioriterpl.Visibility = Visibility.Visible;
                            labelnotecauserpl.Visibility = Visibility.Visible;
                            labelcauserpl.Visibility = Visibility.Visible;
                            labelnotedaterpl.Visibility = Visibility.Visible;
                            labeltel1arpl.Visibility = Visibility.Visible;
                            labelnotetel1arpl.Visibility = Visibility.Visible;
                            labeltel2arpl.Visibility = Visibility.Visible;
                            labelnotetel2arpl.Visibility = Visibility.Visible;
                            labeldatearpl.Visibility = Visibility.Visible;
                            labelheurearpl.Visibility = Visibility.Visible;
                            TBheurearpl.Visibility = Visibility.Visible;
                            TBndatearpl.Visibility = Visibility.Visible;
                            TBnumtel1arpl.Visibility = Visibility.Visible;
                            TBnotenumtel1arpl.Visibility = Visibility.Visible;
                            TBnumtel2arpl.Visibility = Visibility.Visible;
                            TBnotenumtel2arpl.Visibility = Visibility.Visible;
                            TBnotedatearpl.Visibility = Visibility.Visible;
                            CBcauserpl.Visibility = Visibility.Visible;
                            CBprioritearpl.Visibility = Visibility.Visible;
                            TBnotecausearpl.Visibility = Visibility.Visible;

                            HideRDV();
                            HideInjoigniable();
                            HideFauxnum();
                            HideNoninter();
                            HideNEnvoieEmail();
                            HideEnvoieSms();
                        }

                        if (TBEtatrappel.SelectedItem.ToString() == "Rendez-vous")
                        {
                            labeldateRDV.Visibility = Visibility.Visible;
                            labelheureRDV.Visibility = Visibility.Visible;
                            labelnotedateRDV.Visibility = Visibility.Visible;
                            labeladresseRDV.Visibility = Visibility.Visible;
                            labelcontactRDV.Visibility = Visibility.Visible;
                            TBdateRDV.Visibility = Visibility.Visible;
                            TBheureRDV.Visibility = Visibility.Visible;
                            TBnoteRDV.Visibility = Visibility.Visible;
                            TBadresseRDV.Visibility = Visibility.Visible;
                            TBcontactRDV.Visibility = Visibility.Visible;
                            HideInjoigniable();
                            HideFauxnum();
                            HideNoninter();
                            HideNEnvoieEmail();
                            HideEnvoieSms();
                            HideARappeler();
                        }

                   
                }
            }
        }

        public void HideInjoigniable()
        {

                TBnoteraping.Visibility = Visibility.Hidden;
                labelnoteinj.Visibility = Visibility.Hidden;
        }

        public void HideFauxnum()
        {

            TBnoterapfauxnum.Visibility = Visibility.Hidden;
            labelnoteinj.Visibility = Visibility.Hidden;
        }

        public void HideNoninter()
        {

            TBnoterapnoninter.Visibility = Visibility.Hidden;
            labelnoteinj.Visibility = Visibility.Hidden;
        }

        public void HideNEnvoieEmail()
        {

            TBmail1rapenv.Visibility = Visibility.Hidden;
            TBnotemail1rapenv.Visibility = Visibility.Hidden;
            TBmail2rapenv.Visibility = Visibility.Hidden;
            TBnotemail2rapenv.Visibility = Visibility.Hidden;
            TBnotegeneralerapenv.Visibility = Visibility.Hidden;
            CBEtatenvmail.Visibility = Visibility.Hidden;

            labelmail1env.Visibility = Visibility.Hidden;
            labelnotenotemail1env.Visibility = Visibility.Hidden;
            labelmail2env.Visibility = Visibility.Hidden;
            labelnotenotemail2env.Visibility = Visibility.Hidden;
            labeletatenv.Visibility = Visibility.Hidden;
            labelnotegeneralenv.Visibility = Visibility.Hidden;
        }

        public void HideEnvoieSms()
        {

            TBtel1rapsms.Visibility = Visibility.Hidden;
            TBnottel1rapsms.Visibility = Visibility.Hidden;
            TBtel2rapsms.Visibility = Visibility.Hidden;
            TBnotetel2rapsms.Visibility = Visibility.Hidden;
            CBEtatenvsms.Visibility = Visibility.Hidden;
            TBnotegeneralerapsms.Visibility = Visibility.Hidden;
            labelnotegeneralsms.Visibility = Visibility.Hidden;
            labeletatsms.Visibility = Visibility.Hidden;
            labeltel1sms.Visibility = Visibility.Hidden;
            labeltel2sms.Visibility = Visibility.Hidden;
            labelnotenotetel2sms.Visibility = Visibility.Hidden;
            labelnotenottel1sms.Visibility = Visibility.Hidden;
        }

        public void HideARappeler()
        {

            labelprioriterpl.Visibility = Visibility.Hidden;
            labelnotecauserpl.Visibility = Visibility.Hidden;
            labelcauserpl.Visibility = Visibility.Hidden;
            labelnotedaterpl.Visibility = Visibility.Hidden;
            labeltel1arpl.Visibility = Visibility.Hidden;
            labelnotetel1arpl.Visibility = Visibility.Hidden;
            labeltel2arpl.Visibility = Visibility.Hidden;
            labelnotetel2arpl.Visibility = Visibility.Hidden;
            labeldatearpl.Visibility = Visibility.Hidden;
            labelheurearpl.Visibility = Visibility.Hidden;
            TBheurearpl.Visibility = Visibility.Hidden;
            TBndatearpl.Visibility = Visibility.Hidden;
            TBnumtel1arpl.Visibility = Visibility.Hidden;
            TBnotenumtel1arpl.Visibility = Visibility.Hidden;
            TBnumtel2arpl.Visibility = Visibility.Hidden;
            TBnotenumtel2arpl.Visibility = Visibility.Hidden;
            TBnotedatearpl.Visibility = Visibility.Hidden;
            CBcauserpl.Visibility = Visibility.Hidden;
            CBprioritearpl.Visibility = Visibility.Hidden;
            TBnotecausearpl.Visibility = Visibility.Hidden;
         }

        public void HideRDV()
        {
            labeldateRDV.Visibility = Visibility.Hidden;
            labelheureRDV.Visibility = Visibility.Hidden;
            labelnotedateRDV.Visibility = Visibility.Hidden;
            labeladresseRDV.Visibility = Visibility.Hidden;
            labelcontactRDV.Visibility = Visibility.Hidden;
            TBdateRDV.Visibility = Visibility.Hidden;
            TBheureRDV.Visibility = Visibility.Hidden;
            TBnoteRDV.Visibility = Visibility.Hidden;
            TBadresseRDV.Visibility = Visibility.Hidden;
            TBcontactRDV.Visibility = Visibility.Hidden;
        }

        private void BtAjouterrappel_MouseEnter(object sender, MouseEventArgs e)
        {
            BtAjouterrapel.Opacity = 1;
        }

        private void BtAjouterrappel_MouseLeave(object sender, MouseEventArgs e)
        {
            BtAjouterrapel.Opacity = 0.5;
        }
        private Boolean champsVideRappel()
        {
            if (TBEtatrappel.SelectedItem == null || TBentrap.Equals(""))
            {
                return true;
            }
            return false;
        }
        private void BtAjoutererrappel_Click(object sender, RoutedEventArgs e)
        {
            if (champsVideRappel())
            {
                Afficher_Msg_Erreur_rappel("Erreur : champ(s) vide(s)");
            }
            else
            {
                ActionDemander = "Ajout";
                cacherGroupeenAA();
            }
        }

        private void BtModifiererrappel_MouseEnter(object sender, MouseEventArgs e)
        {
            BtModifierrappel.Opacity = 1;
        }

        private void BtModifiererrappel_MouseLeave(object sender, MouseEventArgs e)
        {
            BtModifierrappel.Opacity = 0.5;
        }

        private void BtModifiererrappel_Click(object sender, RoutedEventArgs e)
        {
            if (champsVideRappel())
            {
                Afficher_Msg_Erreur_rappel("Erreur : champ(s) vide(s)");
            }
            else
            {
                ActionDemander = "Modifier";
                cacherGroupeenAA();
            }
        }

        private void BtSupprimerrappel_MouseEnter(object sender, MouseEventArgs e)
        {
            BtSupprimerrappel.Opacity = 1;
        }

        private void BtSupprimererrappel_Click(object sender, RoutedEventArgs e)
        {
            if (champsVideRappel())
            {
                Afficher_Msg_Erreur_rappel("Erreur : champ(s) vide(s)");
            }
            else
            {
                ActionDemander = "Supprimer";
                cacherGroupeenAA();
            }
        }

        private void BtSupprimerrappel_MouseLeave(object sender, MouseEventArgs e)
        {
            BtSupprimerrappel.Opacity = 0.5;
        }

        private void BtConfirmerrappel_MouseEnter(object sender, MouseEventArgs e)
        {
            BtConfirmerrappel.Opacity = 1;
        }

        private void BtConfirmerrappel_MouseLeave(object sender, MouseEventArgs e)
        {
            BtConfirmerrappel.Opacity = 0.5;
        }

        private void BtAnnulerrappel_MouseEnter(object sender, MouseEventArgs e)
        {
            BtAnnulerrappel.Opacity = 1;
        }

        private void BtAnnulerrappel_MouseLeave(object sender, MouseEventArgs e)
        {
            BtAnnulerrappel.Opacity =0.5;
        }

        private void BtAnnulerrappel_Click(object sender, RoutedEventArgs e)
        {
            ActionDemander = "";
            cacherGroupeenBB();
        }
        private void ViderChampsRappel()
        {
            TBIden.Text = "";
            TBentrap.Text = "";
             TBtelrap.Text = "";
            TBnomrap.Text = "";
            TBposterap.Text = "";
            TBtelrap.Text = "";
            TBprenomrap.Text = "";   
            TBnoteraping.Text = "";
            TBnoterapfauxnum.Text = "";
            TBnoterapnoninter.Text = "";
            TBmail1rapenv.Text = "";
            TBnotemail1rapenv.Text = "";
            TBmail2rapenv.Text = "";
            TBnotemail2rapenv.Text = "";
            TBnotegeneralerapenv.Text = "";
            TBtel1rapsms.Text = "";
            TBnottel1rapsms.Text = "";
            TBtel2rapsms.Text = "";
            TBnotetel2rapsms.Text = "";
            TBnotegeneralerapsms.Text = "";
            TBnumtel1arpl.Text = "";
            TBnumtel2arpl.Text = "";
            TBnotenumtel2arpl.Text = "";
            TBnotenumtel1arpl.Text = "";
            TBnotecausearpl.Text = "";
            TBcontactRDV.Text = "";
            TBadresseRDV.Text = "";
            TBnoteRDV.Text = "";
            TBheureRDV.Text = "";
            TBdateRDV.Text = "";
            TBheurearpl.Text = "";
            TBndatearpl.Text = "";
            TBnotedatearpl.Text = "";

             

        }

        private void BtConfirmerrappel_Click(object sender, RoutedEventArgs e)
        {
            
             if (champsVideRappel())
                {
                    Afficher_Msg_Erreur("Erreur : champ(s) vide(s)");
                }
            
                    else
                    {
                        String idrap;
                        String idenrap;
                        idenrap = TBentrap.Text;
                        if (TBidrap.Text.Equals(""))
                        {
                            idrap = "0";
                         }
                        else
                        {
                            idrap = TBidrap.Text;
                        }
                        Injoignable Injoig = new Injoignable(Int16.Parse(idrap), Int16.Parse(idenrap), TBdaterap.Text, TBdheurerap.Text, TBtelrap.Text, TBnomrap.Text, TBprenomrap.Text, TBposterap.Text, TBEtatrappel.Text, TBnoteraping.Text);
                        fauxnumero fauxnum = new fauxnumero(Int16.Parse(idrap), Int16.Parse(idenrap), TBdaterap.Text, TBdheurerap.Text, TBtelrap.Text, TBnomrap.Text, TBprenomrap.Text, TBposterap.Text, TBEtatrappel.Text, TBnoterapfauxnum.Text);
                        noninteresse noninter = new noninteresse(Int16.Parse(idrap), Int16.Parse(idenrap), TBdaterap.Text, TBdheurerap.Text, TBtelrap.Text, TBnomrap.Text, TBprenomrap.Text, TBposterap.Text, TBEtatrappel.Text, TBnoterapnoninter.Text);
                        envoiemail envoiem = new envoiemail(Int16.Parse(idrap), Int16.Parse(idenrap), TBdaterap.Text, TBdheurerap.Text, TBtelrap.Text, TBnomrap.Text, TBprenomrap.Text, TBposterap.Text, TBEtatrappel.Text, TBmail1rapenv.Text, TBnotemail1rapenv.Text, TBmail2rapenv.Text, TBnotemail2rapenv.Text, CBEtatenvmail.Text, TBnotegeneralerapenv.Text);
                        envoisms envoies = new envoisms(Int16.Parse(idrap), Int16.Parse(idenrap), TBdaterap.Text, TBdheurerap.Text, TBtelrap.Text, TBnomrap.Text, TBprenomrap.Text, TBposterap.Text, TBEtatrappel.Text, TBtel1rapsms.Text, TBnottel1rapsms.Text, TBtel2rapsms.Text, TBnotetel2rapsms.Text, CBEtatenvsms.Text, TBnotegeneralerapsms.Text);
                        arappeler arapp = new arappeler(Int16.Parse(idrap), Int16.Parse(idenrap), TBdaterap.Text, TBdheurerap.Text, TBtelrap.Text, TBnomrap.Text, TBprenomrap.Text, TBposterap.Text, TBEtatrappel.Text, TBnumtel1arpl.Text, TBnotenumtel1arpl.Text, TBnumtel2arpl.Text, TBnotenumtel2arpl.Text, TBndatearpl.Text, TBheurearpl.Text, TBnotedatearpl.Text, CBcauserpl.Text, TBnotecausearpl.Text, CBprioritearpl.Text);
                        rendezvous rendezv = new rendezvous(Int16.Parse(idrap), Int16.Parse(idenrap), TBdaterap.Text, TBdheurerap.Text, TBtelrap.Text, TBnomrap.Text, TBprenomrap.Text, TBposterap.Text, TBEtatrappel.Text, TBdateRDV.Text, TBheureRDV.Text, TBnoteRDV.Text, TBadresseRDV.Text, TBcontactRDV.Text);

                       
                 
                 //MessageBox.Show(" "+CHEtat.IsChecked.Value);
                        if (ActionDemander.Equals("Ajout"))
                        {
                            int iddenrap = Int16.Parse(TBentrap.Text);

                            if (TBEtatrappel.SelectedValue.ToString() == "Injoignable" )
                            {
                                int res = la_foire.Dao.InjoignableC.AjouterRappelInjoignable(Injoig);
                                if (res == 1)
                                {
                                    Afficher_Msg_Confirmation_rappel("Rappel est bien ajouter");
                                    ViderChampsRappel();
                                    cacherGroupeenBB();
                                    foreach (Window window in Application.Current.Windows)
                                    {
                                        if (window.GetType() == typeof(AfficherRappel))
                                        {
                                            List<Injoignable> reader = InjoignableC.GetAllrappelInjoignable();
                                            (window as AfficherRappel).DataGridRappelInjoignable.ItemsSource = null;
                                            (window as AfficherRappel).DataGridRappelInjoignable.ItemsSource = reader;
                                            List<fauxnumero> reader1 = fauxnumeroC.GetAllrappelFauxnumero();
                                            (window as AfficherRappel).DataGridRappelFauxNum.ItemsSource = null;
                                            (window as AfficherRappel).DataGridRappelFauxNum.ItemsSource = reader1;
                                            List<noninteresse> reader2 = noninteresseC.GetAllrappelNoninteresse();
                                            (window as AfficherRappel).DataGridRappelNonInter.ItemsSource = null;
                                            (window as AfficherRappel).DataGridRappelNonInter.ItemsSource = reader2;
                                            List<envoiemail> reader3 = envoiemailC.GetAllrappelEnvoiemail();
                                            (window as AfficherRappel).DataGridRappelEnvoieMail.ItemsSource = null;
                                            (window as AfficherRappel).DataGridRappelEnvoieMail.ItemsSource = reader3;
                                            List<envoisms> reader4 = envoismsC.GetAllrappelEnvoisms();
                                            (window as AfficherRappel).DataGridRappelEnvoieSms.ItemsSource = null;
                                            (window as AfficherRappel).DataGridRappelEnvoieSms.ItemsSource = reader4;
                                            List<arappeler> reader5 = arappelerC.GetAllrappelArappeler();
                                            (window as AfficherRappel).DataGridRappelArapp.ItemsSource = null;
                                            (window as AfficherRappel).DataGridRappelArapp.ItemsSource = reader5;
                                            List<rendezvous> reader6 = rendezvousC.GetAllrappelRendezvous();
                                            (window as AfficherRappel).DataGridRappelRDV.ItemsSource = null;
                                            (window as AfficherRappel).DataGridRappelRDV.ItemsSource = reader6; 

                                        }
                                    }
                                  }
                                else
                                {
                                    Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                    cacherGroupeenBB();
                                }

                                cacherGroupeenBB();
                            }
                            else {  if (TBEtatrappel.SelectedValue.ToString() == "Faux numéro")
                            {
                                int res = la_foire.Dao.fauxnumeroC.AjouterRappelFauxnumero(fauxnum);
                                if (res == 1)
                                {
                                    Afficher_Msg_Confirmation_rappel("Rappel est bien ajouter");
                                    ViderChampsRappel();
                                    cacherGroupeenBB();


                                }
                                else
                                {
                                    Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                    cacherGroupeenBB();
                                }

                                cacherGroupeenBB();

                                
                            }

                            else
                            {
                                if (TBEtatrappel.SelectedValue.ToString() == "Non intéressé")
                                {
                                    int res = la_foire.Dao.noninteresseC.AjouterRappelNoninteresse(noninter);
                                    if (res == 1)
                                    {
                                        Afficher_Msg_Confirmation_rappel("Rappel est bien ajouter");
                                        ViderChampsRappel();
                                        cacherGroupeenBB();

                                        la_foire.Dao.noninteresseC.ModifierEtatEntreprise(ent, iddenrap);
                                    }
                                    else
                                    {
                                        Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                        cacherGroupeenBB();
                                    }

                                    cacherGroupeenBB();


                                }

                                else
                                {
                                    if (TBEtatrappel.SelectedValue.ToString() == "Envoie mail")
                                    {
                                        int res = la_foire.Dao.envoiemailC.AjouterRappelEnvoiemail(envoiem);
                                        if (res == 1)
                                        {
                                            Afficher_Msg_Confirmation_rappel("Rappel est bien ajouter");
                                            ViderChampsRappel();
                                            cacherGroupeenBB();
                                            la_foire.Dao.envoismsC.ModifierEtatEntreprise(ent, iddenrap);


                                        }
                                        else
                                        {
                                            Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                            cacherGroupeenBB();
                                        }

                                        cacherGroupeenBB();


                                    }

                                    else
                                    {
                                        if (TBEtatrappel.SelectedValue.ToString() == "Envoie sms")
                                        {
                                            int res = la_foire.Dao.envoismsC.AjouterRappelEnvoisms(envoies);
                                            if (res == 1)
                                            {
                                                Afficher_Msg_Confirmation_rappel("Rappel est bien ajouter");
                                                ViderChampsRappel();
                                                cacherGroupeenBB();
                                                la_foire.Dao.envoismsC.ModifierEtatEntreprise(ent, iddenrap);


                                            }
                                            else
                                            {
                                                Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                cacherGroupeenBB();
                                            }

                                            cacherGroupeenBB();
                                        }

                                        else
                                        {

                                            if (TBEtatrappel.SelectedValue.ToString() == "A rappeler")
                                            {
                                                int res = la_foire.Dao.arappelerC.AjouterRappelArappeler(arapp);
                                                if (res == 1)
                                                {
                                                    Afficher_Msg_Confirmation_rappel("Rappel est bien ajouter");
                                                    ViderChampsRappel();
                                                    cacherGroupeenBB();
                                                    la_foire.Dao.envoismsC.ModifierEtatEntreprise(ent, iddenrap);


                                                }
                                                else
                                                {
                                                    Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                    cacherGroupeenBB();
                                                }

                                                cacherGroupeenBB();
                                            }

                                            else
                                            {
                                                if (TBEtatrappel.SelectedValue.ToString() == "Rendez-vous")
                                                {
                                                    int res = la_foire.Dao.rendezvousC.AjouterRappelRendezvous(rendezv);
                                                    if (res == 1)
                                                    {
                                                        Afficher_Msg_Confirmation_rappel("Rappel est bien ajouter");
                                                        ViderChampsRappel();
                                                        cacherGroupeenBB();
                                                        la_foire.Dao.envoismsC.ModifierEtatEntreprise(ent, iddenrap);


                                                    }
                                                    else
                                                    {
                                                        Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                        cacherGroupeenBB();
                                                    }

                                                    cacherGroupeenBB();
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                                   
                                    
                          }
                        }
                        else
                        {
                            if (ActionDemander.Equals("Modifier"))
                            {
                                int iddrap = Int16.Parse(TBidrap.Text);

                                 if (TBEtatrappel.SelectedValue.ToString() == "Injoignable")
                                {
                                    int res = la_foire.Dao.InjoignableC.ModifierRappelInjoignable(Injoig, iddrap);
                                    if (res == 1)
                                    {
                                        Afficher_Msg_Confirmation_rappel("Rappel est bien Modifier");
                                        ViderChampsRappel();
                                        cacherGroupeenBB();



                                    }
                                    else
                                    {
                                        Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                        cacherGroupeenBB();
                                    }

                                    cacherGroupeenBB();
                                }
                                else
                                {
                                    if (TBEtatrappel.SelectedValue.ToString() == "Faux numéro")
                                    {
                                        int res = la_foire.Dao.fauxnumeroC.ModifierRappelFauxnumero(fauxnum, iddrap);
                                        if (res == 1)
                                        {
                                            Afficher_Msg_Confirmation_rappel("Rappel est bien Modifier");
                                            ViderChampsRappel();
                                            cacherGroupeenBB();


                                        }
                                        else
                                        {
                                            Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                            cacherGroupeenBB();
                                        }

                                        cacherGroupeenBB();


                                    }

                                    else
                                    {
                                        if (TBEtatrappel.SelectedValue.ToString() == "Non intéressé")
                                        {
                                            int res = la_foire.Dao.noninteresseC.ModifierRappelNoninteresse(noninter, iddrap);
                                            if (res == 1)
                                            {
                                                Afficher_Msg_Confirmation_rappel("Rappel est bien Modifier");
                                                ViderChampsRappel();
                                                cacherGroupeenBB();

                                             }
                                            else
                                            {
                                                Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de Modifier");
                                                cacherGroupeenBB();
                                            }

                                            cacherGroupeenBB();


                                        }

                                        else
                                        {
                                            if (TBEtatrappel.SelectedValue.ToString() == "Envoie mail")
                                            {
                                                int res = la_foire.Dao.envoiemailC.ModifierRappelEnvoiemail(envoiem, iddrap);
                                                if (res == 1)
                                                {
                                                    Afficher_Msg_Confirmation_rappel("Rappel est bien Modifier");
                                                    ViderChampsRappel();
                                                    cacherGroupeenBB();
 

                                                }
                                                else
                                                {
                                                    Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                    cacherGroupeenBB();
                                                }

                                                cacherGroupeenBB();


                                            }

                                            else
                                            {
                                                if (TBEtatrappel.SelectedValue.ToString() == "Envoie sms")
                                                {
                                                    int res = la_foire.Dao.envoismsC.ModifierRappelEnvoisms(envoies, iddrap);
                                                    if (res == 1)
                                                    {
                                                        Afficher_Msg_Confirmation_rappel("Rappel est bien Modifier");
                                                        ViderChampsRappel();
                                                        cacherGroupeenBB();
 

                                                    }
                                                    else
                                                    {
                                                        Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                        cacherGroupeenBB();
                                                    }

                                                    cacherGroupeenBB();
                                                }

                                                else
                                                {

                                                    if (TBEtatrappel.SelectedValue.ToString() == "A rappeler")
                                                    {
                                                        int res = la_foire.Dao.arappelerC.ModifierRappelArappeler(arapp,iddrap);
                                                        if (res == 1)
                                                        {
                                                            Afficher_Msg_Confirmation_rappel("Rappel est bien Modifier");
                                                            ViderChampsRappel();
                                                            cacherGroupeenBB();
 

                                                        }
                                                        else
                                                        {
                                                            Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                            cacherGroupeenBB();
                                                        }

                                                        cacherGroupeenBB();
                                                    }

                                                    else
                                                    {
                                                        if (TBEtatrappel.SelectedValue.ToString() == "Rendez-vous")
                                                        {
                                                            int res = la_foire.Dao.rendezvousC.ModifierRappelRendezvous(rendezv, iddrap);
                                                            if (res == 1)
                                                            {
                                                                Afficher_Msg_Confirmation_rappel("Rappel est bien Modifier");
                                                                ViderChampsRappel();
                                                                cacherGroupeenBB();
 

                                                            }
                                                            else
                                                            {
                                                                Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                                cacherGroupeenBB();
                                                            }

                                                            cacherGroupeenBB();
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }


                                }
                            }
                            else
                            {
                                if (ActionDemander.Equals("Supprimer"))
                                {
                                    int iddrap = Int16.Parse(TBidrap.Text);

                                    if (TBEtatrappel.SelectedValue.ToString() == "Injoignable")
                                    {
                                        int res = la_foire.Dao.InjoignableC.SupprimerRappelInjoignable(iddrap);
                                        if (res == 1)
                                        {
                                            Afficher_Msg_Confirmation_rappel("Rappel est bien Supprimer");
                                            ViderChampsRappel();
                                            cacherGroupeenBB();



                                        }
                                        else
                                        {
                                            Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                            cacherGroupeenBB();
                                        }

                                        cacherGroupeenBB();
                                    }
                                    else
                                    {
                                        if (TBEtatrappel.SelectedValue.ToString() == "Faux numéro")
                                        {
                                            int res = la_foire.Dao.fauxnumeroC.SupprimerRappelFauxnumero(iddrap);
                                            if (res == 1)
                                            {
                                                Afficher_Msg_Confirmation_rappel("Rappel est bien Supprimer");
                                                ViderChampsRappel();
                                                cacherGroupeenBB();


                                            }
                                            else
                                            {
                                                Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                cacherGroupeenBB();
                                            }

                                            cacherGroupeenBB();


                                        }

                                        else
                                        {
                                            if (TBEtatrappel.SelectedValue.ToString() == "Non intéressé")
                                            {
                                                int res = la_foire.Dao.noninteresseC.SupprimerRappelNoninteresse(iddrap);
                                                if (res == 1)
                                                {
                                                    Afficher_Msg_Confirmation_rappel("Rappel est bien Supprimer");
                                                    ViderChampsRappel();
                                                    cacherGroupeenBB();

                                                }
                                                else
                                                {
                                                    Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de Modifier");
                                                    cacherGroupeenBB();
                                                }

                                                cacherGroupeenBB();


                                            }

                                            else
                                            {
                                                if (TBEtatrappel.SelectedValue.ToString() == "Envoie mail")
                                                {
                                                    int res = la_foire.Dao.envoiemailC.SupprimerRappelEnvoiemail(iddrap);
                                                    if (res == 1)
                                                    {
                                                        Afficher_Msg_Confirmation_rappel("Rappel est bien Supprimer");
                                                        ViderChampsRappel();
                                                        cacherGroupeenBB();


                                                    }
                                                    else
                                                    {
                                                        Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                        cacherGroupeenBB();
                                                    }

                                                    cacherGroupeenBB();


                                                }

                                                else
                                                {
                                                    if (TBEtatrappel.SelectedValue.ToString() == "Envoie sms")
                                                    {
                                                        int res = la_foire.Dao.envoismsC.SupprimerRappelEnvoisms(iddrap);
                                                        if (res == 1)
                                                        {
                                                            Afficher_Msg_Confirmation_rappel("Rappel est bien Supprimer");
                                                            ViderChampsRappel();
                                                            cacherGroupeenBB();


                                                        }
                                                        else
                                                        {
                                                            Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                            cacherGroupeenBB();
                                                        }

                                                        cacherGroupeenBB();
                                                    }

                                                    else
                                                    {

                                                        if (TBEtatrappel.SelectedValue.ToString() == "A rappeler")
                                                        {
                                                            int res = la_foire.Dao.arappelerC.SupprimerRappelArappeler(iddrap);
                                                            if (res == 1)
                                                            {
                                                                Afficher_Msg_Confirmation_rappel("Rappel est bien Supprimer");
                                                                ViderChampsRappel();
                                                                cacherGroupeenBB();


                                                            }
                                                            else
                                                            {
                                                                Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                                cacherGroupeenBB();
                                                            }

                                                            cacherGroupeenBB();
                                                        }

                                                        else
                                                        {
                                                            if (TBEtatrappel.SelectedValue.ToString() == "Rendez-vous")
                                                            {
                                                                int res = la_foire.Dao.rendezvousC.SupprimerRappelRendezvous(iddrap);
                                                                if (res == 1)
                                                                {
                                                                    Afficher_Msg_Confirmation_rappel("Rappel est bien Supprimer");
                                                                    ViderChampsRappel();
                                                                    cacherGroupeenBB();


                                                                }
                                                                else
                                                                {
                                                                    Afficher_Msg_Erreur_rappel("Erreur de connexion à la base de données");
                                                                    cacherGroupeenBB();
                                                                }

                                                                cacherGroupeenBB();
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }


                                    }
                                }


                            }



                        }

                    }
                cacherGroupeenB();
                ViderChanpsEntreprise();
                     

                 
            }

        private void btviderchampsrappel_Click(object sender, RoutedEventArgs e)
        {
            ViderChampsRappel();
        }

        private void afficherentreprisesrapprel_Click(object sender, RoutedEventArgs e)
        {
            AfficherEntrepriseRappel afenrap = new AfficherEntrepriseRappel();
            afenrap.Show();
        }

        private void afficherRapprel_Click(object sender, RoutedEventArgs e)
        {
            AfficherRappel affrapp = new AfficherRappel();
            affrapp.Show();
        }

         

     

    

        

   

       

    }
}

