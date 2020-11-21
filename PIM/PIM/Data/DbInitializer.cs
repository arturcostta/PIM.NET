using System;
using System.Collections.Generic;
using System.Linq;
using PIM.Models;
using System.Threading.Tasks;

namespace PIM.Data
{
    public class DbInitializer
    {
        public static void Initialize(PIMContext context)
        {

            context.Database.EnsureCreated();

            if (context.pessoas.Any())
            {
                return;
            }

            var pessoas = new Pessoa[]
            {
                new Pessoa{nome="Artur",cpf="23456789"},
                new Pessoa{nome="Jose",cpf="222333444"},
                new Pessoa{nome="Carlos",cpf="111555888"},
                new Pessoa{nome="Ze",cpf="999999"}
            };

            foreach(Pessoa p in pessoas)
            {
                context.pessoas.Add(p);
            }

            context.SaveChanges();
        }
    }
}
