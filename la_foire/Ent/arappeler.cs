using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class arappeler
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
        private string tel1;
        private string note1;
        private string tel2;
        private string note2;
        private string daterap;
        private string heurerap;
        private string notedaterap;
        private string causerap;
        private string notecauserap;
        private string priorite;
        
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
     public string  TEL1
        {
            get
            {
                return this.tel1;
            }
            set
            {
                this.tel1 = value;
            }
     }
     public string NOTE1
     {
         get
         {
             return this.note1;
         }
         set
         {
             this.note1 = value;
         }
     }

     public string TEL2
     {
         get
         {
             return this.tel2;
         }
         set
         {
             this.tel2 = value;
         }
     }
     public string NOTE2
     {
         get
         {
             return this.note2;
         }
         set
         {
             this.note2 = value;
         }
     }
     public string DATERAP
     {
         get
         {
             return this.daterap;
         }
         set
         {
             this.daterap = value;
         }
     }
     public string HEURERAP
     {
         get
         {
             return this.heurerap;
         }
         set
         {
             this.heurerap = value;
         }
     }
     public string NOTEDATERAP
     {
         get
         {
             return this.notedaterap;
         }
         set
         {
             this.notedaterap = value;
         }
     }
     public string CAUSERAP
     {
         get
         {
             return this.causerap;
         }
         set
         {
             this.causerap = value;
         }
     }
     public string NOTECAUSERAP
     {
         get
         {
             return this.notecauserap;
         }
         set
         {
             this.notecauserap = value;
         }
     }

     public string PRIORITE
     {
         get
         {
             return this.priorite;
         }
         set
         {
             this.priorite = value;
         }
     }
   
     
 

        
        #endregion

        #region contructeurs

     public arappeler()
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
            this.tel1 = "";
            this.note1 = "";
            this.tel2 = "";
            this.note2 = "";
            this.daterap = ""; 
            this.heurerap = "";
            this.notedaterap = "";
            this.causerap = "";
            this.notecauserap = "";
            this.priorite = "";
        
      
        }

     public arappeler(int identreprise, String date, String heure, String numtel, String nom, String prenom, String poste, String reponse, String tel1, String note1, String tel2, String note2, String daterap, String heurerap, String notedaterap, String causerap, String notecauserap, String priorite)
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
            this.tel1 = tel1;
            this.note1 = note1;
            this.tel2 = tel2;
            this.note2 = note2;
            this.daterap = daterap;
            this.heurerap = heurerap;
            this.notedaterap = notedaterap;
            this.causerap = causerap;
            this.notecauserap = notecauserap;
            this.priorite = priorite;
        }
        public arappeler(int id,int identreprise, String date, String heure, String numtel, String nom, String prenom, String poste, String reponse, String tel1, String note1, String tel2, String note2, String daterap, String heurerap, String notedaterap, String causerap, String notecauserap, String priorite)
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
            this.tel1 = tel1;
            this.note1 = note1;
            this.tel2 = tel2;
            this.note2 = note2;
            this.daterap = daterap;
            this.heurerap = heurerap;
            this.notedaterap = notedaterap;
            this.causerap = causerap;
            this.notecauserap = notecauserap;
            this.priorite = priorite;
        }

           #endregion
    }
}
