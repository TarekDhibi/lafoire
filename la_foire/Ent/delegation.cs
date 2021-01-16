using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class delegation
    {
         #region porpriétés
                private int id;
                private string nom;
                private int idGouv;
 

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

        public delegation()
        {
            this.id = 0;
            this.nom = "";
            this.idGouv = 0;

            

        }



        public delegation(int id, string nom, int idGouv)
        {
            this.id = id;
            this.nom = nom;
            this.idGouv = idGouv;
         

        }
         #endregion
    }
}
