using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.models
{
    class Classe
    {
        private int id;
        private String libelle;
        private int nbreEtudiant;

        public Classe()
        {
        }

        public Classe(string libelle, int nbreEtudiant)
        {
            this.Libelle = libelle;
            this.NbreEtudiant = nbreEtudiant;
        }

        public Classe(int id, string libelle, int nbreEtudiant)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.NbreEtudiant = nbreEtudiant;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int NbreEtudiant { get => nbreEtudiant; set => nbreEtudiant = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }



}
