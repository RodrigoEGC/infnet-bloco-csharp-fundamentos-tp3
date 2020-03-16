using DomainTP3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfraEstrutura.Data
{
    public class AniversarianteDB
    {
        private static List<Aniversariante> aniversarianteList = new List<Aniversariante>();

        public List<Aniversariante> Pesquisar(string termoPesquisa)
        {
            return aniversarianteList.Where(x => x.Nome.ToUpper().Contains(termoPesquisa.ToUpper())).ToList();

        }
        public void Adicionar(Aniversariante aniversariante)
        {
            aniversarianteList.Add(aniversariante);
        }


    }
}
