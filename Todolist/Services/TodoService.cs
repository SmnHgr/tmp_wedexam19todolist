using System.Collections.Generic;

namespace Todolist.Services
{
    public class TodoService : ITodoService
    {
        private List<Todo> _todos = new List<Todo>();
        
        public IEnumerable<Todo> GetTodos()
        {
            return _todos;
        }

        public void AddTodo(string text)
        {
            _todos.Add(new Todo(text));
        }

        public void RemoveTodo(string id)
        {
            var rmTodo = _todos.Find(todo => todo.Id == id);
            _todos.Remove(rmTodo);
        }
    }
}