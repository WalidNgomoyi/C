using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.models
{
    class Detail
    {
        private String annee;
        private List<String> modules;
        //ManyToOne
        private Classe classe;
        private Professeur professeur;


        public string Annee { get => annee; set => annee = value; }
        public List<string> Modules { get => modules; set => modules = value; }
        public Classe Classe { get => classe; set => classe = value; }
        public Professeur Professeur { get => professeur; set => professeur = value; }

        public Detail()
        {
        }

        public Detail(string annee, Classe classe, Professeur professeur)
        {
            this.annee = annee;
            this.classe = classe;
            this.professeur = professeur;
        }
    }
}
