using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class Injoignable
    {
        #region porpriétés
        private int id;
        private int identreprise;
        private string date;
        private string heure;
        private string numtel;
        private string nom;
        private string prenom;
        private string poste;
        private string reponse;
        private string note;
        
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
        public int IDENTREPRISE
        {
            get
            {
                return this.identreprise;
            }
            set
            {
                this.identreprise = value;
            }
        }
        public string DATE
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public string HEURE
        {
            get
            {
                return this.heure;
            }
            set
            {
                this.heure = value;
            }
        }
        public string NUMTEL
        {
            get
            {
                return this.numtel;
            }
            set
            {
                this.numtel = value;
            }
        }
        public string  NOM
        {
            get
            {
                return this.nom ;
            }
            set
            {
                this.nom  = value;
            }
        }
        public string PRENOM
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.prenom = value;
            }
        }
     public string POSTE 
        {
            get
            {
                return this.poste ;
            }
            set
            {
                this.poste  = value;
            }
     }
     public string  REPONSE
        {
            get
            {
                return this.reponse;
            }
            set
            {
                this.reponse  = value;
            }
}
     public string  NOTE
        {
            get
            {
                return this.note ;
            }
            set
            {
                this.note  = value;
            }
     }
   
     
 

        
        #endregion

        #region contructeurs

        public Injoignable()
        {
            this.id = 0;
            this.identreprise =0;
            this.date = "";
            this.heure = "";
            this.numtel = "";
            this.nom = "";
            this.prenom = "";
            this.poste = "";
            this.reponse = "";
            this.note = "";
      
        }

        public Injoignable(int identreprise, String date, String heure, String numtel, String nom, String prenom, String poste, String reponse, String note )
        {
            this.id = 0;
            this.identreprise = identreprise;
            this.date = date;
            this.heure = heure;
            this.numtel = numtel;
            this.nom = nom;
            this.prenom = prenom;
            this.poste = poste;
            this.reponse = reponse;
            this.note =note;
        }
        public Injoignable(int id,int identreprise, String date, String heure, String numtel, String nom, String prenom, String poste, String reponse, String note)
        {
            this.id = 0;
            this.identreprise = identreprise;
            this.date = date;
            this.heure = heure;
            this.numtel = numtel;
            this.nom = nom;
            this.prenom = prenom;
            this.poste = poste;
            this.reponse = reponse;
            this.note = note;
        }

           #endregion
    }
}
