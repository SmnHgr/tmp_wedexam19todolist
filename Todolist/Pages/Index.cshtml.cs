using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Todolist.Services;

namespace Todolist.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITodoService _todoService;

        public List<Todo> TodoList { get; set; }

        public IndexModel(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public void OnGet()
        {
            TodoList = _todoService.GetTodos().ToList();
        }

        public void OnPost(string text)
        {
            _todoService.AddTodo(text);
            TodoList = _todoService.GetTodos().ToList();
        }

        public void OnPostRemove(string id)
        {
            _todoService.RemoveTodo(id);
            TodoList = _todoService.GetTodos().ToList();
        }
    }
}