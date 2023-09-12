using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chien
{
    class UnChien
    {
        private string _nom;
        private string _race;
        private uint _age;
        private bool _vaccin;
        private bool _poilu;
        private bool _puce;
        private bool _sexe;
        private string _couleur;

        

        public UnChien(string nom, string race, uint age, bool vaccin, bool poilu, bool queu, bool sexe, string couleur)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _vaccin = vaccin;
            _poilu = poilu;
            _sexe = sexe;
            _couleur = couleur;
        }

        public uint Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool Poilu
        {
            get { return _poilu; }
            set { _poilu = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public bool Vaccin
        {
            get { return _vaccin; }
            set { _vaccin = value; }
        }

        public string AfficherCaracteristiques()
        {
            string chaine = "Nom : " + _nom  + " Age : " + _age + " Race : " + _race + " Vaccin : " + _vaccin + " Poilu : " + _poilu + " Puce : " + _puce + " Sexe : " + _sexe + " Couleur : " + _couleur;  
            return chaine;
        }
    }
}

