using System.Collections;
using System.Collections.Generic;

namespace Todolist.Services
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetTodos();
        void AddTodo(string text);
        void RemoveTodo(string id);
    }
}