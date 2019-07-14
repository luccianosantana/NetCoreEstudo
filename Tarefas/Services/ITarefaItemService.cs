using System;
using System.Collections.Generic;

namespace Tarefas.Services
{
    public interface ITarefaItemService
    {
         Task<IEnumerable<TempTarefaItem>> GetItemAsync();
    }
}