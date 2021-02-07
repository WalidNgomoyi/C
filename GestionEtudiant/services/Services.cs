using GestionEtudiant.dao;
using GestionEtudiant.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.services
{
    //Implemente les Uses Case
    class Services
    {
        // Dao (Data Acces Object)
        // ORM (Object Relationnel Mapping)
        // Objet =>enreigistrement de la BD (insert, update,delete)
        //Enregistrement 
        private DaoClasse daoClasse;
        private DaoPersonne daoPersonne;
        private DaoDetail daoDetail;
        private Personne personne;

        public Services()
        {
            daoClasse = new DaoClasse();
            daoPersonne = new DaoPersonne();
            daoDetail = new DaoDetail();
        }

        public List<Etudiant> ListerEtudiantParClasse(Classe classe)
        {
            return daoPersonne.FindByClasse(classe);
        }

        public bool CreerClasse(Classe classe)
        {
            return daoClasse.Insert(classe) != 0;
        }
        public List<Classe> ListerClasse()
        {
            return daoClasse.FindAll();

        }
        public bool CreerPersonne(Personne personne)
        {
            return daoPersonne.Insert(personne)!= 0;

        }
        public Personne seConnecter (String login, String pwd)
        {
            return ;

        }

    }
}
