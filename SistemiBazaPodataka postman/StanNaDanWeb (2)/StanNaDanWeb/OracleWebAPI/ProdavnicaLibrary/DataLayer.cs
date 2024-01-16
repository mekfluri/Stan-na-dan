using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using StanNaDanv2.Mapiranja;
using System;

namespace StanNaDanLibrary
{
    internal class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static readonly object objLock = new object();

        //funkcija na zahtev otvara sesiju
        public static ISession GetSession()
        {
            //ukoliko session factory nije kreiran
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                    {
                        _factory = CreateSessionFactory();
                    }
                }
            }

            return _factory.OpenSession();
        }

        //konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                            .ShowSql()
                            .ConnectionString(c =>
                                c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18478;Password=S18478"));

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NekretninaMapiranja>())
                    .BuildSessionFactory();
            }
            catch (Exception)
            {
                // Error handling
                return null;
            }
        }
    }
}
