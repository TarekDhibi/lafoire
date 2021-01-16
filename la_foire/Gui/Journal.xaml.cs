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
    /// Logique d'interaction pour JournalP.xaml
    /// </summary>
    public partial class Journal : Window
    {
         public Journal()
        {
            InitializeComponent();

            List<JournalP> reader = JournalPC.GetAll();
            DataGridAgents.ItemsSource = null;
            DataGridAgents.ItemsSource = reader;
           
        }
     
    }
}
