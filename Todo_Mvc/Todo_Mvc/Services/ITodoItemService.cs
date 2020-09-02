using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo_Mvc.Models;

namespace Todo_Mvc.Services
{
    public interface ITodoItemService
    {
        
            Task<TodoItem[]> GetIncompleteItemsAsync();
        
    }
}
