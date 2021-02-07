using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.models
{
    class Etudiant : Personne
    {
        private String tuteur;
        //ManyToOne
        private Classe classe;

        public string Tuteur { get => tuteur; set => tuteur = value; }
        public Classe Classe { get => classe; set => classe = value; }

        public Etudiant()
        {
            Type = "Etudiant";
        }

        public Etudiant(int id, string nomComplet, string tuteur) : base(id, nomComplet)
        {
            this.Tuteur = tuteur;
            Type = "Etudiant";
        }

        public Etudiant(string nomComplet, string tuteur) : base(nomComplet)
        {
            this.Tuteur = tuteur;
            Type = "Etudiant";
        }
    }
}


