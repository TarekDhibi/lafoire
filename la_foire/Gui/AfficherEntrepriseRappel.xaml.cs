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
    /// Logique d'interaction pour AfficherEntrepriseRappel.xaml
    /// </summary>
    public partial class AfficherEntrepriseRappel : Window
    {
        public AfficherEntrepriseRappel()
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
                        (window as Accueil).TBentrap.Text = (DataGridEntreprise.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text; ;
                        
                        
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
