using GestContact.DAL.Fluent;
using GestContact.DAL.Fluent.Repositories;
using GestContact.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InitDatabase.CreateSessionFactory("Data Source=CEDRIC-DEV;Initial Catalog=GestContact;Integrated Security=true;");

            Civilite civilite = new Civilite() { LibelleCourt = "M.", LibelleLong = "Monsieur" };
            CiviliteRepository.Save(civilite);
        }
    }
}
