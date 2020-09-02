using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo_Mvc.Models;
using Todo_Mvc.Services;

namespace Todo_Mvc.Controllers
{
    public class TodoController : Controller
    {

        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();
            var model = new TodoViewModel()
            {
                Items = items
            };
            return View(model);

        }
    }
}
