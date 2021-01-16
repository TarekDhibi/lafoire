using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class JournalP
    {
        #region proprietes

        private int id;
        private int idAdmin;
        private String heure;
        private String action;
   

        #endregion

        #region getter and setter

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

        public int IDADMIN
        {
            get
            {
                return this.idAdmin;
            }
            set
            {
                this.idAdmin = value;
            }
        }

        public String HEURE
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

        public String ACTION
        {
            get
            {
                return this.action;
            }
            set
            {
                this.action = value;
            }
        }

 
        #endregion

        #region contructeurs

        public JournalP()
        {
            this.id = 0;
            this.idAdmin = 0;
            this.heure = "";
            this.action = "";
             
        }

        public JournalP(int idAdmin, String heure, String action)
        {
            this.id = 0;
            this.idAdmin = idAdmin;
            this.heure = heure;
            this.action = action;
             
        }

        public JournalP(int id, int idAdmin, String heure, String action )
        {
            this.id = id;
            this.idAdmin = idAdmin;
            this.heure = heure;
            this.action = action;
             
        }

        #endregion
    }
}
