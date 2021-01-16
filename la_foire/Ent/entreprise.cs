using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class entreprise
    {
        #region porpriétés
        private int id;
        private string nom;
        private string cat;
        private string scat;
        private string governorat;
        private string delegation;
        private string etat;
        private string localite;
        private string nomg;
        private string prenomg;
        private string adresse;
        private string telg1;
        private string telg2;
        private string telg3;
        private string telen1;
        private string telen2;
        private string telen3;
        private string mailg1;
        private string mailg2;
        private string mailg3;
        private string mailen1;
        private string mailen2;
        private string mailen3;
        private string source;
        private string web;
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
        public string CAT
        {
            get
            {
                return this.cat;
            }
            set
            {
                this.cat = value;
            }
        }
        public string SCAT
        {
            get
            {
                return this.scat;
            }
            set
            {
                this.scat = value;
            }
        }
        public string GOVERNORAT
        {
            get
            {
                return this.governorat;
            }
            set
            {
                this.governorat = value;
            }
        }
        public string  DELEGATION
        {
            get
            {
                return this.delegation ;
            }
            set
            {
                this.delegation  = value;
            }
        }
        public string ETAT
        {
            get
            {
                return this.etat;
            }
            set
            {
                this.etat = value;
            }
        }
     public string LOCALITE 
        {
            get
            {
                return this.localite ;
            }
            set
            {
                this.localite  = value;
            }
     }
     public string  NOMG
        {
            get
            {
                return this.nomg ;
            }
            set
            {
                this.nomg  = value;
            }
}
     public string  PRENOMG
        {
            get
            {
                return this.prenomg ;
            }
            set
            {
                this.prenomg  = value;
            }
     }
     public string  ADRESSE
        {
            get
            {
                return this.adresse ;
            }
            set
            {
                this.adresse  = value;
            }
     }
     public string TELG1 
        {
            get
            {
                return this.telg1 ;
            }
            set
            {
                this.telg1  = value;
            }
     }
     public string  TELG2
        {
            get
            {
                return this.telg2 ;
            }
            set
            {
                this.telg2  = value;
            }
     }
     public string  TELG3
        {
            get
            {
                return this.telg3 ;
            }
            set
            {
                this.telg3  = value;
            }
     }
 
     public string TELEN1 
        {
            get
            {
                return this.telen1 ;
            }
            set
            {
                this.telen1  = value;
            }
     }
     public string TELEN2 
        {
            get
            {
                return this.telen2 ;
            }
            set
            {
                this.telen2  = value;
            }
     }
     public string  TELEN3
        {
            get
            {
                return this.telen3 ;
            }
            set
            {
                this.telen3  = value;
            }
     }
     public string  MAILG1
        {
            get
            {
                return this.mailg1 ;
            }
            set
            {
                this.mailg1  = value;
            }
}
       public string  MAILG2
        {
            get
            {
                return this.mailg2 ;
            }
            set
            {
                this.mailg2  = value;
            }
}
     public string  MAILG3
        {
            get
            {
                return this.mailg3 ;
            }
            set
            {
                this.mailg3  = value;
            }
}
 
     public string  MAILEN1
        {
            get
            {
                return this.mailen1 ;
            }
            set
            {
                this.mailen1  = value;
            }
}
     public string  MAILEN2
        {
            get
            {
                return this.mailen2 ;
            }
            set
            {
                this.mailen2  = value;
            }
}
     public string  MAILEN3
        {
            get
            {
                return this.mailen3 ;
            }
            set
            {
                this.mailen3  = value;
            }
}
     public string SOURCE 
        {
            get
            {
                return this.source ;
            }
            set
            {
                this.source  = value;
            }
}
     public string WEB 
        {
            get
            {
                return this.web ;
            }
            set
            {
                this.web = value;
            }
}

        
        #endregion

        #region contructeurs

        public entreprise()
        {
            this.id = 0;
            this.nom ="";
            this.cat = "";
            this.scat = "";
            this.governorat = "";
            this.delegation = "";
            this.etat = "";
            this.localite = "";
            this.nomg = "";
            this.prenomg = "";
            this.adresse = "";
            this.telg1 = "";
            this.telg2 = "";
            this.telg3 = ""; 
            this.telen1 = "";
            this.telen2 = "";
            this.telen3 = "";
            this.mailg1 = "";
            this.mailg2 = "";
            this.mailg3 = "";
            this.mailen1 = "";
            this.mailen2 = "";
            this.mailen3 = "";
            this.source = "";
            this.web = "";
             
        }

        public entreprise(String nom, String cat, String scat, String governorat, String delegation, String etat,String localite, String nomg, String prenomg, String adresse, String telg1, String telg2, String telg3, String telen1, String telen2, String telen3, String mailg1, String mailg2, String mailg3, String mailen1, String mailen2, String mailen3, String source, String web)
        {
            this.id = 0;
            this.nom = nom;
            this.cat = cat;
            this.scat = scat;
            this.governorat = governorat;
            this.delegation = delegation;
            this.localite = localite;
            this.nomg = nomg;
            this.prenomg = prenomg;
            this.adresse = adresse;
            this.telg1 = telg1;
            this.telg2 = telg2;
            this.telg3 = telg3;
            this.etat = etat;
            this.telen1 = telen1;
            this.telen2 = telen2;
            this.telen3 = telen3;
            this.mailg1 = mailg1;
            this.mailg2 = mailg2;
            this.mailg3 = mailg3;
            this.mailen1 = mailen1;
            this.mailen2 = mailen2;
            this.mailen3 = mailen3;
            this.source = source;
            this.web = web;

        }
        public entreprise(int id, String nom, String cat, String scat, String governorat, String delegation, String etat, String localite, String nomg, String prenomg, String adresse, String telg1, String telg2, String telg3, String telen1, String telen2, String telen3, String mailg1, String mailg2, String mailg3, String mailen1, String mailen2, String mailen3, String source, String web)
        {
            this.id = 0;
            this.nom = nom;
            this.cat = cat;
            this.scat = scat;
            this.governorat = governorat;
            this.delegation = delegation;
            this.etat = etat;
            this.localite = localite;
            this.nomg = nomg;
            this.prenomg = prenomg;
            this.adresse = adresse;
            this.telg1 = telg1;
            this.telg2 = telg2;
            this.telg3 = telg3;
        
            this.telen1 = telen1;
            this.telen2 = telen2;
            this.telen3 = telen3;
            this.mailg1 = mailg1;
            this.mailg2 = mailg2;
            this.mailg3 = mailg3;
            this.mailen1 = mailen1;
            this.mailen2 = mailen2;
            this.mailen3 = mailen3;
            this.source = source;
            this.web = web;

        }

           #endregion

    }
}
