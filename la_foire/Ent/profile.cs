﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_foire.Ent
{
    class profile
    {

        #region porpriétés
        private int id;
        private string login;
        private string mail;
        private string mdp;
        private string Role;
        private Boolean etat;

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
        public string LOGIN
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }
        public string MAIL
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }
        public string MDP
        {
            get
            {
                return this.mdp;
            }
            set
            {
                this.mdp = value;
            }
        }

        public string ROLE
        {
            get
            {
                return this.Role;
            }
            set
            {
                this.Role = value;
            }
        }


        public Boolean ETAT
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

        #endregion

        #region constructeurs

        public profile()
        {
            this.id = 0;
            this.login = "";
            this.mail = "";
            this.mdp = "";
            this.Role = "";
            this.etat = false;

        }
        public profile(int id)
        {
            this.id = id;
            this.login = "";
            this.mail = "";
            this.mdp = "";
            this.Role = "";
            this.etat = false;

        }

        public profile(int id, string login)
        {
            this.id = id;
            this.login = login;
            this.mail = "";
            this.mdp = "";
            this.Role = "";
            this.etat = false;

        }
        public profile(string login, string mdp)
        {
            this.id = 0;
            this.login = login;
            this.mail = "";
            this.mdp = mdp;
            this.Role = "";
            this.etat = false;

        }
        public profile(int id, string login, string mdp, string mail)
        {
            this.id = id;
            this.login = login;
            this.mail = mail;
            this.mdp = mdp;
            this.Role = "";
            this.etat = false;

        }
        public profile(int id, string login, string mdp, string mail, string service)
        {
            this.id = id;
            this.login = login;
            this.mail = mail;
            this.mdp = mdp;
            this.Role = service;
            this.etat = false;

        }
        public profile(int id, string login, string mdp, string mail, string service, bool etat)
        {
            this.id = id;
            this.login = login;
            this.mail = mail;
            this.mdp = mdp;
            this.Role = service;
            this.etat = etat;

        }
        public profile(profile a)
        {
            this.id = a.id;
            this.login = a.login;
            this.mail = a.mail;
            this.mdp = a.mdp;
            this.Role = a.Role;
            this.etat = a.etat;

        }
        #endregion

    }
}
