using System;
using System.Collections.Generic;
using System.Text;

namespace Serialisation
{
    class Etudiant
    {
        static int compteur=0;
        public int id { get; set; }
        public string nom{get;set;}
        public List<Etudiant> amis { get; set; }
        public Etudiant(string nom)
        {
            this.id = ++compteur;
            this.nom = nom;
            this.amis = new List<Etudiant>();
        }
        public Etudiant() { }
        public void ajouterAmie(Etudiant e) { this.amis.Add(e); }
        string detalEtu()
        {
            return "\nDétail Etudiant =>   Nom : " + this.nom;
        }
        public override string ToString()
        {
            string res =detalEtu();
            res += "\nSes amis : ";
            foreach(Etudiant e in amis)
            {
                res += "\t"+e.detalEtu();
            }
            return res;
        }
    }
}
