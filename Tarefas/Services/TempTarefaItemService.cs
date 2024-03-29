using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Models;


namespace Tarefas.Services
{
    public class TempTarefaItemService : ITarefaItemService
    {
        public Task<IEnumerable<TarefaItem>> GetItemAsync()
        {
            //Retorna um array de itens de tarefa
            IEnumerable<TarefaItem> itens = new []
            {
                new TarefaItem
                {
                    Nome = "Aprender ASP.NET core 2.0",
                    EstaCompleta = false,
                    DataConclusao = DateTimeOffset.Now.AddDays(30)
                },
                new TarefaItem
                {
                    Nome = "Criar aplicações Web",
                    EstaCompleta = false,
                    DataConclusao = DateTimeOffset.Now.AddDays(60)
                }  
            };
            return Task.FromResult(itens);
        }
    }
}