using GestionEtudiant.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.dao
{
    class DaoPersonne : IDao<Personne>
    {
        private DaoSql sqlServer;

        public DaoPersonne()
        {
            sqlServer = new DaoSql();
        }
        public int Insert(Personne pers)
        {
            String sql = String.Format("INSERT INTO `personne` (type, nom_complet, tuteur, modules, grade, classe_id, matricule) "
                + "VALUES ({0},{1},{2},{3},{4},{5},{6})", pers.NomComplet, pers.Type, ((Etudiant)pers).Tuteur,
                models.Convert.ListToString(((Professeur)pers).Modules,
                ((Professeur)pers).Grade),
                ((Professeur)pers).Matricule,
                ((Etudiant)pers).Classe.Id
                 );

            return sqlServer.ExecuteUpdate(sql);
        }

        public Personne FindUserConnect(String login, String pwd)
        {
            Personne pers = null;
            String sql = String.Format("select * from personne"+" where login={0} and pwd={1}",login,pwd);
            // Executer la requete

            return pers;

        }



        public List<Etudiant> FindByClasse(Classe classe)
        {
            List<Etudiant> lEtudiants = new List<Etudiant>();
            //ecrire la requete
            String sql = String.Format("select p.id,nom_complet,tuteur ,classe_id,libelle,nbre_etudiant from personne p,classe cl where type='Etudiant' and classe_id={0}"
                +" and cl.id=p.classe_id ",classe.Id);
            //remplir la list

            return lEtudiants;
        }

        internal int Insert(object personne)
        {
            throw new NotImplementedException();
        }
    }
}
