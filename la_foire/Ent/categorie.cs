using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class categorie
    {
        #region porpriétés
                private int id;
                private string nom;
 

                #endregion

        #region Getter & Setter
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string NOM
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }
 
        #endregion

        #region constructeurs

        public categorie()
        {
            this.id = 0;
            this.nom = "";
            

        }



        public categorie(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
         

        }
         #endregion

    }
}
