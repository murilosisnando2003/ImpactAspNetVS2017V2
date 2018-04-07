using Pessoal.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Helper
/// </summary
/// 
namespace Pessoal.WebForms
{
    public class Helper
    {
        public Helper()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }

        public List<Prioridade> ObterPrioridades()
        {
            return Enum.GetValues(typeof(Prioridade)).Cast<Prioridade>().ToList();
        }

    }
}