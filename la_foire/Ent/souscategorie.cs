using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class souscategorie
    {

         #region porpriétés
                private int id;
                private string nom;
                private int iden;
 

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

        public souscategorie()
        {
            this.id = 0;
            this.nom = "";
            this.iden = 0;

            

        }



        public souscategorie(int id, string nom,int iden)
        {
            this.id = id;
            this.nom = nom;
            this.iden = iden;
         

        }
         #endregion
    }
}
