using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class gouvernorat
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

        public gouvernorat()
        {
            this.id = 0;
            this.nom = "";
            

        }



        public gouvernorat(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
         

        }
         #endregion

    }
     
}
