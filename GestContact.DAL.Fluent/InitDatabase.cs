using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.DAL.Fluent
{
    public class InitDatabase
    {
        /// <summary>
        /// Stocke la factory de session
        /// </summary>
        internal static ISessionFactory SessionFactory { get; private set; }

        /// <summary>
        /// Initialise la connexion à la base de données
        /// </summary>
        /// <param name="connectionString">chaine de connexion</param>
        public static void CreateSessionFactory(string connectionString)
        {
            SessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString).ShowSql()) // Choix du type de SGBD
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<InitDatabase>()) // Ajout des Maps selon le type de l'assembly
                .ExposeConfiguration(UpdateSchema) // Prise en compte du mode de génération de la BDD
                .BuildSessionFactory(); // Génération du session Factory
        }

        /// <summary>
        /// Supprimer le schéma et de le recréer à chaque lancement (utile pour les T.U)
        /// </summary>
        /// <param name="config"></param>
        static void BuildSchema(Configuration config)
        {
            new SchemaExport(config).Drop(true, true);
            new SchemaExport(config).Create(true, true);
        }

        /// <summary>
        /// Mettre à jour les tables de la base de données
        /// </summary>
        /// <param name="config"></param>
        static void UpdateSchema(Configuration config)
        {
            new SchemaUpdate(config).Execute(true, true);
        }

        /// <summary>
        /// Teste la cohérence entre d'une part les Maps et d'autre part la Base de Données
        /// </summary>
        /// <param name="config"></param>
        static void ValidateSchema(Configuration config)
        {
            new SchemaValidator(config).Validate();
        }
    }
}
