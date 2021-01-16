using la_foire.Dao;
using la_foire.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Logique d'interaction pour AfficherRappel.xaml
    /// </summary>
    public partial class AfficherRappel : Window
    {
        public AfficherRappel()
        {
            InitializeComponent();

            TBEtatrappelafficher.Items.Add("Injoignable");
            TBEtatrappelafficher.Items.Add("Faux numéro");
            TBEtatrappelafficher.Items.Add("Non intéressé");
            TBEtatrappelafficher.Items.Add("Envoie mail");
            TBEtatrappelafficher.Items.Add("Envoie sms");
            TBEtatrappelafficher.Items.Add("A rappeler");
            TBEtatrappelafficher.Items.Add("Rendez-vous");

            List<Injoignable> reader = InjoignableC.GetAllrappelInjoignable();
            DataGridRappelInjoignable.ItemsSource = null;
            DataGridRappelInjoignable.ItemsSource = reader;

            List<fauxnumero> reader1 = fauxnumeroC.GetAllrappelFauxnumero();
            DataGridRappelFauxNum.ItemsSource = null;
            DataGridRappelFauxNum.ItemsSource = reader1;
            List<noninteresse> reader2 = noninteresseC.GetAllrappelNoninteresse();
            DataGridRappelNonInter.ItemsSource = null;
            DataGridRappelNonInter.ItemsSource = reader2;
            List<envoiemail> reader3 = envoiemailC.GetAllrappelEnvoiemail();
            DataGridRappelEnvoieMail.ItemsSource = null;
            DataGridRappelEnvoieMail.ItemsSource = reader3;
            List<envoisms> reader4 = envoismsC.GetAllrappelEnvoisms();
            DataGridRappelEnvoieSms.ItemsSource = null;
            DataGridRappelEnvoieSms.ItemsSource = reader4;
            List<arappeler> reader5 = arappelerC.GetAllrappelArappeler();
            DataGridRappelArapp.ItemsSource = null;
            DataGridRappelArapp.ItemsSource = reader5;
            List<rendezvous> reader6= rendezvousC.GetAllrappelRendezvous();
            DataGridRappelRDV.ItemsSource = null;
            DataGridRappelRDV.ItemsSource = reader6;
        }
         private void LoadAllrappelFauxNum(String champ, String texte)
        {
            List<fauxnumero> reader = fauxnumeroC.GetAllRappelFauxnumerofiltre(champ, texte);
            DataGridRappelFauxNum.ItemsSource = null;
            DataGridRappelFauxNum.ItemsSource = reader;
        }
        private void LoadAllrappelInjoignable(String champ, String texte)
        {
            List<Injoignable> reader = InjoignableC.GetAllRappelInjoignablefiltre(champ, texte);
            DataGridRappelInjoignable.ItemsSource = null;
            DataGridRappelInjoignable.ItemsSource = reader;
        }
        private void LoadAllrappelNonInter(String champ, String texte)
        {
            List<noninteresse> reader = noninteresseC.GetAllRappelNoninteressefiltre(champ, texte);
            DataGridRappelNonInter.ItemsSource = null;
            DataGridRappelNonInter.ItemsSource = reader;
        }
        private void LoadAllrappelEnvoiMail(String champ, String texte)
        {
            List<envoiemail> reader = envoiemailC.GetAllRappelEnvoiemailfiltre(champ, texte);
            DataGridRappelEnvoieMail.ItemsSource = null;
            DataGridRappelEnvoieMail.ItemsSource = reader;
        }
        private void LoadAllrappelEnvoiSms(String champ, String texte)
        {
            List<envoisms> reader = envoismsC.GetAllRappelEnvoismsfiltre(champ, texte);
            DataGridRappelEnvoieSms.ItemsSource = null;
            DataGridRappelEnvoieSms.ItemsSource = reader;
        }

        private void LoadAllrappelArapp(String champ, String texte)
        {
            List<arappeler> reader = arappelerC.GetAllRappelArappelerfiltre(champ, texte);
            DataGridRappelArapp.ItemsSource = null;
            DataGridRappelArapp.ItemsSource = reader;
        }
        private void LoadAllrappelRDV(String champ, String texte)
        {
            List<rendezvous> reader = rendezvousC.GetAllRappelRendezvousfiltre(champ, texte);
            DataGridRappelRDV.ItemsSource = null;
            DataGridRappelRDV.ItemsSource = reader;
        }
        private void TBEtatrappelafficher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TBEtatrappelafficher.SelectedValue.ToString() == "Injoignable")
            {
                
                DataGridRappelInjoignable.Visibility = Visibility.Visible;
                expanderjoignable.Visibility = Visibility.Visible;
            }
                else{
                DataGridRappelInjoignable.Visibility = Visibility.Hidden;
                expanderjoignable.Visibility = Visibility.Hidden;
                }
            if (TBEtatrappelafficher.SelectedValue.ToString() == "Faux numéro")
            {

                DataGridRappelFauxNum.Visibility = Visibility.Visible;
                expanderFauxNum.Visibility = Visibility.Visible;
            }
            else
            {
                DataGridRappelFauxNum.Visibility = Visibility.Hidden;
                expanderFauxNum.Visibility = Visibility.Hidden;
            }
            if (TBEtatrappelafficher.SelectedValue.ToString() == "Non intéressé")
            {

                DataGridRappelNonInter.Visibility = Visibility.Visible;
                expanderNonInter.Visibility = Visibility.Visible;
            }
            else
            {
                DataGridRappelNonInter.Visibility = Visibility.Hidden;
                expanderNonInter.Visibility = Visibility.Hidden;
            }
            if (TBEtatrappelafficher.SelectedValue.ToString() == "Envoie mail")
            {

                DataGridRappelEnvoieMail.Visibility = Visibility.Visible;
                expanderEnvoieMail.Visibility = Visibility.Visible;
            }
            else
            {
                DataGridRappelEnvoieMail.Visibility = Visibility.Hidden;
                expanderEnvoieMail.Visibility = Visibility.Hidden;
            }
            if (TBEtatrappelafficher.SelectedValue.ToString() == "Envoie sms")
            {

                DataGridRappelEnvoieSms.Visibility = Visibility.Visible;
                expanderEnvoieSms.Visibility = Visibility.Visible;
            }
            else
            {
                DataGridRappelEnvoieSms.Visibility = Visibility.Hidden;
                expanderEnvoieSms.Visibility = Visibility.Hidden;
            }
            if (TBEtatrappelafficher.SelectedValue.ToString() == "A rappeler")
            {

                DataGridRappelArapp.Visibility = Visibility.Visible;
                expanderArapp.Visibility = Visibility.Visible;
            }
            else
            {
                DataGridRappelArapp.Visibility = Visibility.Hidden;
                expanderArapp.Visibility = Visibility.Hidden;
            }
            if (TBEtatrappelafficher.SelectedValue.ToString() == "Rendez-vous")
            {

                DataGridRappelRDV.Visibility = Visibility.Visible;
                expanderRDV.Visibility = Visibility.Visible;
            }
            else
            {
                DataGridRappelRDV.Visibility = Visibility.Hidden;
                expanderRDV.Visibility = Visibility.Hidden;
            } 
            } 
       

        private void TBFiltresinjoignable_KeyUp(object sender, KeyEventArgs e)
        {
            if (TBFiltresinjoignable.Text.Equals(""))
            {
                List<Injoignable> reader = InjoignableC.GetAllrappelInjoignable();
                DataGridRappelInjoignable.ItemsSource = null;
                DataGridRappelInjoignable.ItemsSource = reader;
            }
            else
            {
                switch (CBFiltresInjognable.SelectedIndex)
                {
                    case 0: LoadAllrappelInjoignable("identreprise", TBFiltresinjoignable.Text); break;
                    case 1: LoadAllrappelInjoignable("date", TBFiltresinjoignable.Text); break;
                    case 2: LoadAllrappelInjoignable("heure", TBFiltresinjoignable.Text); break;
                    case 3: LoadAllrappelInjoignable("numtel", TBFiltresinjoignable.Text); break;
                    case 4: LoadAllrappelInjoignable("nom", TBFiltresinjoignable.Text); break;
                    case 5: LoadAllrappelInjoignable("prenom", TBFiltresinjoignable.Text); break;
                    case 6: LoadAllrappelInjoignable("poste", TBFiltresinjoignable.Text); break;
                    case 7: LoadAllrappelInjoignable("note", TBFiltresinjoignable.Text); break;
                    
                }
            }
        }

        private void TBFiltresinjoignable_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBFiltresinjoignable.Text.Equals(""))
            {
                List<Injoignable> reader = InjoignableC.GetAllrappelInjoignable();
                DataGridRappelInjoignable.ItemsSource = null;
                DataGridRappelInjoignable.ItemsSource = reader;
            }
            else
            {
                switch (CBFiltresInjognable.SelectedIndex)
                {
                    case 0: LoadAllrappelInjoignable("identreprise", TBFiltresinjoignable.Text); break;
                    case 1: LoadAllrappelInjoignable("date", TBFiltresinjoignable.Text); break;
                    case 2: LoadAllrappelInjoignable("heure", TBFiltresinjoignable.Text); break;
                    case 3: LoadAllrappelInjoignable("numtel", TBFiltresinjoignable.Text); break;
                    case 4: LoadAllrappelInjoignable("nom", TBFiltresinjoignable.Text); break;
                    case 5: LoadAllrappelInjoignable("prenom", TBFiltresinjoignable.Text); break;
                    case 6: LoadAllrappelInjoignable("poste", TBFiltresinjoignable.Text); break;
                    case 7: LoadAllrappelInjoignable("note", TBFiltresinjoignable.Text); break;

                }
            }
        }

        private void DataGridRappelInjoignable_MouseUp(object sender, MouseButtonEventArgs e)
        {

            object item = DataGridRappelInjoignable.SelectedItem;
            try
            {



                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Accueil))
                    {
                        (window as Accueil).TBidrap.Text = (DataGridRappelInjoignable.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBentrap.Text = (DataGridRappelInjoignable.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdaterap.Text = (DataGridRappelInjoignable.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdheurerap.Text = (DataGridRappelInjoignable.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBtelrap.Text = (DataGridRappelInjoignable.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnomrap.Text = (DataGridRappelInjoignable.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBprenomrap.Text = (DataGridRappelInjoignable.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBposterap.Text = (DataGridRappelInjoignable.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; ;

                        (window as Accueil).TBEtatrappel.Text = "Injoignable";
                     
                        (window as Accueil).TBnoteraping.Text = (DataGridRappelInjoignable.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; ;
                      }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "");
            }
        }

        private void TBFiltresFauxNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (TBFiltresFauxNum.Text.Equals(""))
            {
                List<Injoignable> reader = InjoignableC.GetAllrappelInjoignable();
                DataGridRappelInjoignable.ItemsSource = null;
                DataGridRappelInjoignable.ItemsSource = reader;
            }
            else
            {
                switch (CBFiltresFauxNum.SelectedIndex)
                {
                    case 0: LoadAllrappelFauxNum("identreprise", TBFiltresFauxNum.Text); break;
                    case 1: LoadAllrappelFauxNum("date", TBFiltresFauxNum.Text); break;
                    case 2: LoadAllrappelFauxNum("heure", TBFiltresFauxNum.Text); break;
                    case 3: LoadAllrappelFauxNum("numtel", TBFiltresFauxNum.Text); break;
                    case 4: LoadAllrappelFauxNum("nom", TBFiltresFauxNum.Text); break;
                    case 5: LoadAllrappelFauxNum("prenom", TBFiltresFauxNum.Text); break;
                    case 6: LoadAllrappelFauxNum("poste", TBFiltresFauxNum.Text); break;
                    case 7: LoadAllrappelFauxNum("note", TBFiltresFauxNum.Text); break;

                }
            }
        }

        private void TBFiltresFauxNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBFiltresFauxNum.Text.Equals(""))
            {
                List<Injoignable> reader = InjoignableC.GetAllrappelInjoignable();
                DataGridRappelInjoignable.ItemsSource = null;
                DataGridRappelInjoignable.ItemsSource = reader;
            }
            else
            {
                switch (CBFiltresFauxNum.SelectedIndex)
                {
                    case 0: LoadAllrappelFauxNum("identreprise", TBFiltresFauxNum.Text); break;
                    case 1: LoadAllrappelFauxNum("date", TBFiltresFauxNum.Text); break;
                    case 2: LoadAllrappelFauxNum("heure", TBFiltresFauxNum.Text); break;
                    case 3: LoadAllrappelFauxNum("numtel", TBFiltresFauxNum.Text); break;
                    case 4: LoadAllrappelFauxNum("nom", TBFiltresFauxNum.Text); break;
                    case 5: LoadAllrappelFauxNum("prenom", TBFiltresFauxNum.Text); break;
                    case 6: LoadAllrappelFauxNum("poste", TBFiltresFauxNum.Text); break;
                    case 7: LoadAllrappelFauxNum("note", TBFiltresFauxNum.Text); break;

                }
            }
        }

        private void DataGridRappelFauxNum_MouseUp(object sender, MouseButtonEventArgs e)
        {
            object item = DataGridRappelFauxNum.SelectedItem;
            try
            {



                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Accueil))
                    {
                        (window as Accueil).TBidrap.Text = (DataGridRappelFauxNum.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBentrap.Text = (DataGridRappelFauxNum.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdaterap.Text = (DataGridRappelFauxNum.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdheurerap.Text = (DataGridRappelFauxNum.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBtelrap.Text = (DataGridRappelFauxNum.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnomrap.Text = (DataGridRappelFauxNum.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBprenomrap.Text = (DataGridRappelFauxNum.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBposterap.Text = (DataGridRappelFauxNum.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; ;

                        (window as Accueil).TBEtatrappel.Text = "Faux numéro";

                        (window as Accueil).TBnoterapfauxnum.Text = (DataGridRappelFauxNum.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; ;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "");
            }
        }

        private void TBFiltresNonInter_KeyUp(object sender, KeyEventArgs e)
        {

            if (TBFiltresNonInter.Text.Equals(""))
            {
                List<noninteresse> reader2 = noninteresseC.GetAllrappelNoninteresse();
                DataGridRappelNonInter.ItemsSource = null;
                DataGridRappelNonInter.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresNonInter.SelectedIndex)
                {
                    case 0: LoadAllrappelNonInter("identreprise", TBFiltresNonInter.Text); break;
                    case 1: LoadAllrappelNonInter("date", TBFiltresNonInter.Text); break;
                    case 2: LoadAllrappelNonInter("heure", TBFiltresNonInter.Text); break;
                    case 3: LoadAllrappelNonInter("numtel", TBFiltresNonInter.Text); break;
                    case 4: LoadAllrappelNonInter("nom", TBFiltresNonInter.Text); break;
                    case 5: LoadAllrappelNonInter("prenom", TBFiltresNonInter.Text); break;
                    case 6: LoadAllrappelNonInter("poste", TBFiltresNonInter.Text); break;
                    case 7: LoadAllrappelNonInter("note", TBFiltresNonInter.Text); break;

                }
            }
        }

        private void TBFiltresNonInter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBFiltresNonInter.Text.Equals(""))
            {
                List<noninteresse> reader2 = noninteresseC.GetAllrappelNoninteresse();
                DataGridRappelNonInter.ItemsSource = null;
                DataGridRappelNonInter.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresNonInter.SelectedIndex)
                {
                    case 0: LoadAllrappelNonInter("identreprise", TBFiltresNonInter.Text); break;
                    case 1: LoadAllrappelNonInter("date", TBFiltresNonInter.Text); break;
                    case 2: LoadAllrappelNonInter("heure", TBFiltresNonInter.Text); break;
                    case 3: LoadAllrappelNonInter("numtel", TBFiltresNonInter.Text); break;
                    case 4: LoadAllrappelNonInter("nom", TBFiltresNonInter.Text); break;
                    case 5: LoadAllrappelNonInter("prenom", TBFiltresNonInter.Text); break;
                    case 6: LoadAllrappelNonInter("poste", TBFiltresNonInter.Text); break;
                    case 7: LoadAllrappelNonInter("note", TBFiltresNonInter.Text); break;

                }
            }
        }

        private void DataGridRappelNonInter_MouseUp(object sender, MouseButtonEventArgs e)
        {
            object item = DataGridRappelNonInter.SelectedItem;
            try
            {



                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Accueil))
                    {
                        (window as Accueil).TBidrap.Text = (DataGridRappelNonInter.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBentrap.Text = (DataGridRappelNonInter.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdaterap.Text = (DataGridRappelNonInter.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdheurerap.Text = (DataGridRappelNonInter.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBtelrap.Text = (DataGridRappelNonInter.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnomrap.Text = (DataGridRappelNonInter.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBprenomrap.Text = (DataGridRappelNonInter.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBposterap.Text = (DataGridRappelNonInter.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; ;

                        (window as Accueil).TBEtatrappel.Text = "Non intéressé";

                        (window as Accueil).TBnoterapnoninter.Text = (DataGridRappelNonInter.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; ;
                      }
                }
        }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "");
            }
        }

        private void TBFiltresEnvoieMail_KeyUp(object sender, KeyEventArgs e)
        {
            if (TBFiltresEnvoieMail.Text.Equals(""))
            {
                List<envoiemail> reader2 = envoiemailC.GetAllrappelEnvoiemail();
                DataGridRappelEnvoieMail.ItemsSource = null;
                DataGridRappelEnvoieMail.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresEnvoieMail.SelectedIndex)
                {
                    case 0: LoadAllrappelEnvoiMail("identreprise", TBFiltresEnvoieMail.Text); break;
                    case 1: LoadAllrappelEnvoiMail("date", TBFiltresEnvoieMail.Text); break;
                    case 2: LoadAllrappelEnvoiMail("heure", TBFiltresEnvoieMail.Text); break;
                    case 3: LoadAllrappelEnvoiMail("numtel", TBFiltresEnvoieMail.Text); break;
                    case 4: LoadAllrappelEnvoiMail("nom", TBFiltresEnvoieMail.Text); break;
                    case 5: LoadAllrappelEnvoiMail("prenom", TBFiltresEnvoieMail.Text); break;
                    case 6: LoadAllrappelEnvoiMail("poste", TBFiltresEnvoieMail.Text); break;
                    case 7: LoadAllrappelEnvoiMail("mail1", TBFiltresEnvoieMail.Text); break;
                    case 8: LoadAllrappelEnvoiMail("note1", TBFiltresEnvoieMail.Text); break;
                    case 9: LoadAllrappelEnvoiMail("mail2", TBFiltresEnvoieMail.Text); break;
                    case 10: LoadAllrappelEnvoiMail("note2", TBFiltresEnvoieMail.Text); break;
                    case 11: LoadAllrappelEnvoiMail("etat", TBFiltresEnvoieMail.Text); break;
                    case 12: LoadAllrappelEnvoiMail("notegenerale", TBFiltresEnvoieMail.Text); break;
                }
            }
        }

        private void TBFiltresEnvoieMail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBFiltresEnvoieMail.Text.Equals(""))
            {
                List<envoiemail> reader2 = envoiemailC.GetAllrappelEnvoiemail();
                DataGridRappelEnvoieMail.ItemsSource = null;
                DataGridRappelEnvoieMail.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresEnvoieMail.SelectedIndex)
                {
                    case 0: LoadAllrappelEnvoiMail("identreprise", TBFiltresEnvoieMail.Text); break;
                    case 1: LoadAllrappelEnvoiMail("date", TBFiltresEnvoieMail.Text); break;
                    case 2: LoadAllrappelEnvoiMail("heure", TBFiltresEnvoieMail.Text); break;
                    case 3: LoadAllrappelEnvoiMail("numtel", TBFiltresEnvoieMail.Text); break;
                    case 4: LoadAllrappelEnvoiMail("nom", TBFiltresEnvoieMail.Text); break;
                    case 5: LoadAllrappelEnvoiMail("prenom", TBFiltresEnvoieMail.Text); break;
                    case 6: LoadAllrappelEnvoiMail("poste", TBFiltresEnvoieMail.Text); break;
                    case 7: LoadAllrappelEnvoiMail("mail1", TBFiltresEnvoieMail.Text); break;
                    case 8: LoadAllrappelEnvoiMail("note1", TBFiltresEnvoieMail.Text); break;
                    case 9: LoadAllrappelEnvoiMail("mail2", TBFiltresEnvoieMail.Text); break;
                    case 10: LoadAllrappelEnvoiMail("note2", TBFiltresEnvoieMail.Text); break;
                    case 11: LoadAllrappelEnvoiMail("etat", TBFiltresEnvoieMail.Text); break;
                    case 12: LoadAllrappelEnvoiMail("notegenerale", TBFiltresEnvoieMail.Text); break;
                }
            }
        }

        private void DataGridRappelEnvoieMail_MouseUp(object sender, MouseButtonEventArgs e)
        {
            object item = DataGridRappelEnvoieMail.SelectedItem;
            try
            {



                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Accueil))
                    {
                        (window as Accueil).TBidrap.Text = (DataGridRappelEnvoieMail.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBentrap.Text = (DataGridRappelEnvoieMail.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdaterap.Text = (DataGridRappelEnvoieMail.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdheurerap.Text = (DataGridRappelEnvoieMail.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBtelrap.Text = (DataGridRappelEnvoieMail.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnomrap.Text = (DataGridRappelEnvoieMail.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBprenomrap.Text = (DataGridRappelEnvoieMail.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBposterap.Text = (DataGridRappelEnvoieMail.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; ;

                        (window as Accueil).TBEtatrappel.Text = "Envoie mail";

                        (window as Accueil).TBmail1rapenv.Text = (DataGridRappelEnvoieMail.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnotemail1rapenv.Text = (DataGridRappelEnvoieMail.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBmail2rapenv.Text = (DataGridRappelEnvoieMail.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnotemail2rapenv.Text = (DataGridRappelEnvoieMail.SelectedCells[11].Column.GetCellContent(item) as TextBlock).Text; ;
                        String s = (DataGridRappelEnvoieMail.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text;
                        switch (s)
                        {
                            case "En attente": (window as Accueil).CBEtatenvmail.SelectedIndex = 0; break;
                            case "Validé": (window as Accueil).CBEtatenvmail.SelectedIndex = 1; break;
                             
                        }
                        (window as Accueil).TBnotegeneralerapenv.Text = (DataGridRappelEnvoieMail.SelectedCells[13].Column.GetCellContent(item) as TextBlock).Text; ;

                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "");
            }
        }

        private void TBFiltresEnvoieSms_KeyUp(object sender, KeyEventArgs e)
        {
            if (TBFiltresEnvoieSms.Text.Equals(""))
            {
                List<envoisms> reader2 = envoismsC.GetAllrappelEnvoisms();
                DataGridRappelEnvoieSms.ItemsSource = null;
                DataGridRappelEnvoieSms.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresEnvoieSms.SelectedIndex)
                {
                    case 0: LoadAllrappelEnvoiSms("identreprise", TBFiltresEnvoieSms.Text); break;
                    case 1: LoadAllrappelEnvoiSms("date", TBFiltresEnvoieSms.Text); break;
                    case 2: LoadAllrappelEnvoiSms("heure", TBFiltresEnvoieSms.Text); break;
                    case 3: LoadAllrappelEnvoiSms("numtel", TBFiltresEnvoieSms.Text); break;
                    case 4: LoadAllrappelEnvoiSms("nom", TBFiltresEnvoieSms.Text); break;
                    case 5: LoadAllrappelEnvoiSms("prenom", TBFiltresEnvoieSms.Text); break;
                    case 6: LoadAllrappelEnvoiSms("poste", TBFiltresEnvoieSms.Text); break;
                    case 7: LoadAllrappelEnvoiSms("tell1", TBFiltresEnvoieSms.Text); break;
                    case 8: LoadAllrappelEnvoiSms("note1", TBFiltresEnvoieSms.Text); break;
                    case 9: LoadAllrappelEnvoiSms("tel2", TBFiltresEnvoieSms.Text); break;
                    case 10: LoadAllrappelEnvoiSms("note2", TBFiltresEnvoieSms.Text); break;
                    case 11: LoadAllrappelEnvoiSms("etat", TBFiltresEnvoieSms.Text); break;
                    case 12: LoadAllrappelEnvoiSms("notegenerale", TBFiltresEnvoieSms.Text); break;
                }
            }
        }

        private void TBFiltresEnvoieSms_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBFiltresEnvoieSms.Text.Equals(""))
            {
                List<envoisms> reader2 = envoismsC.GetAllrappelEnvoisms();
                DataGridRappelEnvoieSms.ItemsSource = null;
                DataGridRappelEnvoieSms.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresEnvoieSms.SelectedIndex)
                {
                    case 0: LoadAllrappelEnvoiSms("identreprise", TBFiltresEnvoieSms.Text); break;
                    case 1: LoadAllrappelEnvoiSms("date", TBFiltresEnvoieSms.Text); break;
                    case 2: LoadAllrappelEnvoiSms("heure", TBFiltresEnvoieSms.Text); break;
                    case 3: LoadAllrappelEnvoiSms("numtel", TBFiltresEnvoieSms.Text); break;
                    case 4: LoadAllrappelEnvoiSms("nom", TBFiltresEnvoieSms.Text); break;
                    case 5: LoadAllrappelEnvoiSms("prenom", TBFiltresEnvoieSms.Text); break;
                    case 6: LoadAllrappelEnvoiSms("poste", TBFiltresEnvoieSms.Text); break;
                    case 7: LoadAllrappelEnvoiSms("tell1", TBFiltresEnvoieSms.Text); break;
                    case 8: LoadAllrappelEnvoiSms("note1", TBFiltresEnvoieSms.Text); break;
                    case 9: LoadAllrappelEnvoiSms("tel2", TBFiltresEnvoieSms.Text); break;
                    case 10: LoadAllrappelEnvoiSms("note2", TBFiltresEnvoieSms.Text); break;
                    case 11: LoadAllrappelEnvoiSms("etat", TBFiltresEnvoieSms.Text); break;
                    case 12: LoadAllrappelEnvoiSms("notegenerale", TBFiltresEnvoieSms.Text); break;
                }
            }
        }

        private void DataGridRappelEnvoieSms_MouseUp(object sender, MouseButtonEventArgs e)
        {
            object item = DataGridRappelEnvoieSms.SelectedItem;
            try
            {



                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Accueil))
                    {
                        (window as Accueil).TBidrap.Text = (DataGridRappelEnvoieSms.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBentrap.Text = (DataGridRappelEnvoieSms.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdaterap.Text = (DataGridRappelEnvoieSms.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdheurerap.Text = (DataGridRappelEnvoieSms.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBtelrap.Text = (DataGridRappelEnvoieSms.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnomrap.Text = (DataGridRappelEnvoieSms.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBprenomrap.Text = (DataGridRappelEnvoieSms.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBposterap.Text = (DataGridRappelEnvoieSms.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; ;

                        (window as Accueil).TBEtatrappel.Text = "Envoie sms";

                        (window as Accueil).TBtel1rapsms.Text = (DataGridRappelEnvoieSms.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnottel1rapsms.Text = (DataGridRappelEnvoieSms.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBtel2rapsms.Text = (DataGridRappelEnvoieSms.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnotetel2rapsms.Text = (DataGridRappelEnvoieSms.SelectedCells[11].Column.GetCellContent(item) as TextBlock).Text; ;
                        String s = (DataGridRappelEnvoieSms.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text;
                        switch (s)
                        {
                            case "En attente": (window as Accueil).CBEtatenvsms.SelectedIndex = 0; break;
                            case "Validé": (window as Accueil).CBEtatenvsms.SelectedIndex = 1; break;

                        }
                        (window as Accueil).TBnotegeneralerapsms.Text = (DataGridRappelEnvoieSms.SelectedCells[13].Column.GetCellContent(item) as TextBlock).Text; ;

                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "");
            }
        }

        private void TBFiltresArapp_KeyUp(object sender, KeyEventArgs e)
        {
            if (TBFiltresArapp.Text.Equals(""))
            {
                List<arappeler> reader2 = arappelerC.GetAllrappelArappeler();
                DataGridRappelArapp.ItemsSource = null;
                DataGridRappelArapp.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresArapp.SelectedIndex)
                {
                    case 0: LoadAllrappelArapp("identreprise", TBFiltresEnvoieSms.Text); break;
                    case 1: LoadAllrappelArapp("date", TBFiltresArapp .Text); break;
                    case 2: LoadAllrappelArapp("heure", TBFiltresArapp.Text); break;
                    case 3: LoadAllrappelArapp("numtel", TBFiltresArapp.Text); break;
                    case 4: LoadAllrappelArapp("nom", TBFiltresArapp.Text); break;
                    case 5: LoadAllrappelArapp("prenom", TBFiltresArapp.Text); break;
                    case 6: LoadAllrappelArapp("poste", TBFiltresArapp.Text); break;
                    case 7: LoadAllrappelArapp("tell1", TBFiltresArapp.Text); break;
                    case 8: LoadAllrappelArapp("note1", TBFiltresArapp.Text); break;
                    case 9: LoadAllrappelArapp("tel2", TBFiltresArapp.Text); break;
                    case 10: LoadAllrappelArapp("note2", TBFiltresArapp.Text); break;
                    case 11: LoadAllrappelArapp("daterap", TBFiltresArapp.Text); break;
                    case 12: LoadAllrappelArapp("heurerap", TBFiltresArapp.Text); break;
                    case 13: LoadAllrappelArapp("notedaterap", TBFiltresArapp.Text); break;
                    case 14: LoadAllrappelArapp("causerap", TBFiltresArapp.Text); break;
                    case 15: LoadAllrappelArapp("notecauserap", TBFiltresArapp.Text); break;
                    case 16: LoadAllrappelArapp("priorite", TBFiltresArapp.Text); break;
                }
            }
        }

        private void TBFiltresArapp_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBFiltresArapp.Text.Equals(""))
            {
                List<arappeler> reader2 = arappelerC.GetAllrappelArappeler();
                DataGridRappelArapp.ItemsSource = null;
                DataGridRappelArapp.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresArapp.SelectedIndex)
                {
                    case 0: LoadAllrappelArapp("identreprise", TBFiltresEnvoieSms.Text); break;
                    case 1: LoadAllrappelArapp("date", TBFiltresArapp.Text); break;
                    case 2: LoadAllrappelArapp("heure", TBFiltresArapp.Text); break;
                    case 3: LoadAllrappelArapp("numtel", TBFiltresArapp.Text); break;
                    case 4: LoadAllrappelArapp("nom", TBFiltresArapp.Text); break;
                    case 5: LoadAllrappelArapp("prenom", TBFiltresArapp.Text); break;
                    case 6: LoadAllrappelArapp("poste", TBFiltresArapp.Text); break;
                    case 7: LoadAllrappelArapp("tell1", TBFiltresArapp.Text); break;
                    case 8: LoadAllrappelArapp("note1", TBFiltresArapp.Text); break;
                    case 9: LoadAllrappelArapp("tel2", TBFiltresArapp.Text); break;
                    case 10: LoadAllrappelArapp("note2", TBFiltresArapp.Text); break;
                    case 11: LoadAllrappelArapp("daterap", TBFiltresArapp.Text); break;
                    case 12: LoadAllrappelArapp("heurerap", TBFiltresArapp.Text); break;
                    case 13: LoadAllrappelArapp("notedaterap", TBFiltresArapp.Text); break;
                    case 14: LoadAllrappelArapp("causerap", TBFiltresArapp.Text); break;
                    case 15: LoadAllrappelArapp("notecauserap", TBFiltresArapp.Text); break;
                    case 16: LoadAllrappelArapp("priorite", TBFiltresArapp.Text); break;
                }
            }
        }

        private void DataGridRappelArapp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            object item = DataGridRappelArapp.SelectedItem;
            try
            {



                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Accueil))
                    {
                        (window as Accueil).TBidrap.Text = (DataGridRappelArapp.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBentrap.Text = (DataGridRappelArapp.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdaterap.Text = (DataGridRappelArapp.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdheurerap.Text = (DataGridRappelArapp.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBtelrap.Text = (DataGridRappelArapp.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnomrap.Text = (DataGridRappelArapp.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBprenomrap.Text = (DataGridRappelArapp.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBposterap.Text = (DataGridRappelArapp.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; ;

                        (window as Accueil).TBEtatrappel.Text = "A rappeler";

                        (window as Accueil).TBnumtel1arpl.Text = (DataGridRappelArapp.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnotenumtel1arpl.Text = (DataGridRappelArapp.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnumtel2arpl.Text = (DataGridRappelArapp.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnotenumtel2arpl.Text = (DataGridRappelArapp.SelectedCells[11].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBndatearpl.Text = (DataGridRappelArapp.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBheurearpl.Text = (DataGridRappelArapp.SelectedCells[13].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnotedatearpl.Text = (DataGridRappelArapp.SelectedCells[14].Column.GetCellContent(item) as TextBlock).Text; ;

                        String s = (DataGridRappelArapp.SelectedCells[15].Column.GetCellContent(item) as TextBlock).Text;
                        switch (s)
                        {
                            case "Occupé": (window as Accueil).CBcauserpl.SelectedIndex = 0; break;
                            case "Pas responsable": (window as Accueil).CBcauserpl.SelectedIndex = 1; break;
                            case "Fixer RDV": (window as Accueil).CBcauserpl.SelectedIndex = 2; break;
                            case "Avoir décision": (window as Accueil).CBcauserpl.SelectedIndex = 3; break;
                            case "Autres": (window as Accueil).CBcauserpl.SelectedIndex = 4; break;

                        }
                        (window as Accueil).TBnotecausearpl.Text = (DataGridRappelArapp.SelectedCells[16].Column.GetCellContent(item) as TextBlock).Text; ;

                        String c = (DataGridRappelArapp.SelectedCells[17].Column.GetCellContent(item) as TextBlock).Text;
                        switch (c)
                        {
                            case "Elevée": (window as Accueil).CBprioritearpl.SelectedIndex = 0; break;
                            case "Moyenne": (window as Accueil).CBprioritearpl.SelectedIndex = 1; break;
                            case "Faible": (window as Accueil).CBprioritearpl.SelectedIndex = 2; break;

                        }

                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "");
            }
        }

        private void TBFiltresRDV_KeyUp(object sender, KeyEventArgs e)
        {
            if (TBFiltresRDV.Text.Equals(""))
            {
                List<rendezvous> reader2 = rendezvousC.GetAllrappelRendezvous();
                DataGridRappelRDV.ItemsSource = null;
                DataGridRappelRDV.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresRDV.SelectedIndex)
                {
                    case 0: LoadAllrappelRDV("identreprise", TBFiltresRDV.Text); break;
                    case 1: LoadAllrappelRDV("date", TBFiltresRDV.Text); break;
                    case 2: LoadAllrappelRDV("heure", TBFiltresRDV.Text); break;
                    case 3: LoadAllrappelRDV("numtel", TBFiltresRDV.Text); break;
                    case 4: LoadAllrappelRDV("nom", TBFiltresRDV.Text); break;
                    case 5: LoadAllrappelRDV("prenom", TBFiltresRDV.Text); break;
                    case 6: LoadAllrappelRDV("poste", TBFiltresRDV.Text); break;
                    case 7: LoadAllrappelRDV("daterdv", TBFiltresRDV.Text); break;
                    case 8: LoadAllrappelRDV("heurerdv", TBFiltresRDV.Text); break;
                    case 9: LoadAllrappelRDV("notedaterdv", TBFiltresRDV.Text); break;
                    case 10: LoadAllrappelRDV("adresse", TBFiltresRDV.Text); break;
                    case 11: LoadAllrappelRDV("contact", TBFiltresRDV.Text); break;

                }
            }
        }

        private void TBFiltresRDV_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBFiltresRDV.Text.Equals(""))
            {
                List<rendezvous> reader2 = rendezvousC.GetAllrappelRendezvous();
                DataGridRappelRDV.ItemsSource = null;
                DataGridRappelRDV.ItemsSource = reader2;
            }
            else
            {
                switch (CBFiltresRDV.SelectedIndex)
                {
                    case 0: LoadAllrappelRDV("identreprise", TBFiltresRDV.Text); break;
                    case 1: LoadAllrappelRDV("date", TBFiltresRDV.Text); break;
                    case 2: LoadAllrappelRDV("heure", TBFiltresRDV.Text); break;
                    case 3: LoadAllrappelRDV("numtel", TBFiltresRDV.Text); break;
                    case 4: LoadAllrappelRDV("nom", TBFiltresRDV.Text); break;
                    case 5: LoadAllrappelRDV("prenom", TBFiltresRDV.Text); break;
                    case 6: LoadAllrappelRDV("poste", TBFiltresRDV.Text); break;
                    case 7: LoadAllrappelRDV("daterdv", TBFiltresRDV.Text); break;
                    case 8: LoadAllrappelRDV("heurerdv", TBFiltresRDV.Text); break;
                    case 9: LoadAllrappelRDV("notedaterdv", TBFiltresRDV.Text); break;
                    case 10: LoadAllrappelRDV("adresse", TBFiltresRDV.Text); break;
                    case 11: LoadAllrappelRDV("contact", TBFiltresRDV.Text); break;

                }
            }
        }

        private void DataGridRappelRDV_MouseUp(object sender, MouseButtonEventArgs e)
        {
            object item = DataGridRappelRDV.SelectedItem;
            try
            {



                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Accueil))
                    {
                        (window as Accueil).TBidrap.Text = (DataGridRappelRDV.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBentrap.Text = (DataGridRappelRDV.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdaterap.Text = (DataGridRappelRDV.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBdheurerap.Text = (DataGridRappelRDV.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBtelrap.Text = (DataGridRappelRDV.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnomrap.Text = (DataGridRappelRDV.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBprenomrap.Text = (DataGridRappelRDV.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBposterap.Text = (DataGridRappelRDV.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; ;

                        (window as Accueil).TBEtatrappel.Text = "Rendez-vous";

                        (window as Accueil).TBdateRDV.Text = (DataGridRappelRDV.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBheureRDV.Text = (DataGridRappelRDV.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBnoteRDV.Text = (DataGridRappelRDV.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBadresseRDV.Text = (DataGridRappelRDV.SelectedCells[11].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBcontactRDV.Text = (DataGridRappelRDV.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text; ;
                         
                        

                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "");
            }
        } 
         

         
    } 
}
