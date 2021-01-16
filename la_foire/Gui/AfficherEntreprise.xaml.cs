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
    /// Logique d'interaction pour AfficherEntreprise.xaml
    /// </summary>
    public partial class AfficherEntreprise : Window
    {
        public AfficherEntreprise()
        {
            InitializeComponent();
            List<entreprise> reader = entrepriseC.GetAllEntreprise();
            DataGridEntreprise.ItemsSource = null;
            DataGridEntreprise.ItemsSource = reader;
        
        }
        private void LoadAllEntreprise(String champ, String texte)
        {
            List<entreprise> reader = entrepriseC.GetAllentreprisefiltre(champ, texte);
            DataGridEntreprise.ItemsSource = null;
            DataGridEntreprise.ItemsSource = reader;

        }

        private void TBFiltresent_KeyUp(object sender, KeyEventArgs e)
        {
            if (TBFiltresent.Text.Equals(""))
            {
                List<entreprise> reader = entrepriseC.GetAllEntreprise();
                DataGridEntreprise.ItemsSource = null;
                DataGridEntreprise.ItemsSource = reader;
            }
            else
            {
                switch (CBFiltres.SelectedIndex)
                {
                    case 0: LoadAllEntreprise("nom", TBFiltresent.Text); break;
                    case 1: LoadAllEntreprise("cat", TBFiltresent.Text); break;
                    case 2: LoadAllEntreprise("scat", TBFiltresent.Text); break;
                    case 3: LoadAllEntreprise("governorat", TBFiltresent.Text); break;
                    case 4: LoadAllEntreprise("delegation", TBFiltresent.Text); break;
                    case 5: LoadAllEntreprise("localite", TBFiltresent.Text); break;
                    case 6: LoadAllEntreprise("etat", TBFiltresent.Text); break;
                    case 7: LoadAllEntreprise("nomg", TBFiltresent.Text); break;
                    case 8: LoadAllEntreprise("prenomg", TBFiltresent.Text); break;
                    case 9: LoadAllEntreprise("adresse", TBFiltresent.Text); break;
                    case 10: LoadAllEntreprise("telg1", TBFiltresent.Text); break;
                    case 11: LoadAllEntreprise("telen1", TBFiltresent.Text); break;
                    case 12: LoadAllEntreprise("mailg1", TBFiltresent.Text); break;
                    case 13: LoadAllEntreprise("mailen1", TBFiltresent.Text); break;
                    case 14: LoadAllEntreprise("source", TBFiltresent.Text); break;
                    case 15: LoadAllEntreprise("web", TBFiltresent.Text); break;
                }
            }
        }

        private void TBFiltresent_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBFiltresent.Text.Equals(""))
            {
                List<entreprise> reader = entrepriseC.GetAllEntreprise();
                DataGridEntreprise.ItemsSource = null;
                DataGridEntreprise.ItemsSource = reader;
            }
            else
            {
                switch (CBFiltres.SelectedIndex)
                {
                    case 0: LoadAllEntreprise("nom", TBFiltresent.Text); break;
                    case 1: LoadAllEntreprise("cat", TBFiltresent.Text); break;
                    case 2: LoadAllEntreprise("scat", TBFiltresent.Text); break;
                    case 3: LoadAllEntreprise("governorat", TBFiltresent.Text); break;
                    case 4: LoadAllEntreprise("delegation", TBFiltresent.Text); break;
                    case 5: LoadAllEntreprise("localite", TBFiltresent.Text); break;
                    case 6: LoadAllEntreprise("etat", TBFiltresent.Text); break;
                    case 7: LoadAllEntreprise("nomg", TBFiltresent.Text); break;
                    case 8: LoadAllEntreprise("prenomg", TBFiltresent.Text); break;
                    case 9: LoadAllEntreprise("adresse", TBFiltresent.Text); break;
                    case 10: LoadAllEntreprise("telg1", TBFiltresent.Text); break;
                    case 11: LoadAllEntreprise("telen1", TBFiltresent.Text); break;
                    case 12: LoadAllEntreprise("mailg1", TBFiltresent.Text); break;
                    case 13: LoadAllEntreprise("mailen1", TBFiltresent.Text); break;
                    case 14: LoadAllEntreprise("source", TBFiltresent.Text); break;
                    case 15: LoadAllEntreprise("web", TBFiltresent.Text); break;
                }
            }
        }
        private void DataGridEntreprise_MouseUp(object sender, MouseButtonEventArgs e)
        {


            object item = DataGridEntreprise.SelectedItem;
            try
            {
                


                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Accueil))
                    {
                        (window as Accueil).TBIden.Text = (DataGridEntreprise.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBNom.Text = (DataGridEntreprise.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBIdcat.Text = (DataGridEntreprise.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBIdscat.Text = (DataGridEntreprise.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBGouv.Text = (DataGridEntreprise.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; ;
                       


                        (window as Accueil).TBDel.Text = (DataGridEntreprise.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; ;
                        String s = (DataGridEntreprise.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                        switch (s)
                        {
                            case "Jamais contactée": (window as Accueil).TBEtat.SelectedIndex = 0; break;
                            case "Inscrite": (window as Accueil).TBEtat.SelectedIndex = 1; break;
                            case "Rappels en cours": (window as Accueil).TBEtat.SelectedIndex = 2; break;
                            case "Rappels terminés": (window as Accueil).TBEtat.SelectedIndex = 3; break;
                        }
                        (window as Accueil).TBLoca.Text = (DataGridEntreprise.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBNomg1.Text = (DataGridEntreprise.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBPrenom.Text = (DataGridEntreprise.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBAdresse.Text = (DataGridEntreprise.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBTelg1.Text = (DataGridEntreprise.SelectedCells[11].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBTelg2.Text = (DataGridEntreprise.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBTelg3.Text = (DataGridEntreprise.SelectedCells[13].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBTelen1.Text = (DataGridEntreprise.SelectedCells[14].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBTelen2.Text = (DataGridEntreprise.SelectedCells[15].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBTelen3.Text = (DataGridEntreprise.SelectedCells[16].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBmailg1.Text = (DataGridEntreprise.SelectedCells[17].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBmailg2.Text = (DataGridEntreprise.SelectedCells[18].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBmailg3.Text = (DataGridEntreprise.SelectedCells[19].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBmailen1.Text = (DataGridEntreprise.SelectedCells[20].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBmailen2.Text = (DataGridEntreprise.SelectedCells[21].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBmailen3.Text = (DataGridEntreprise.SelectedCells[22].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBsource.Text = (DataGridEntreprise.SelectedCells[23].Column.GetCellContent(item) as TextBlock).Text; ;
                        (window as Accueil).TBlienweb.Text = (DataGridEntreprise.SelectedCells[24].Column.GetCellContent(item) as TextBlock).Text; ;
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
