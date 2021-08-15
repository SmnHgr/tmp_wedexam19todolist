using System;

namespace Todolist.Services
{
    public class Todo
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string Text { get; set; }

        public Todo(string text)
        {
            Text = text;
        }
        
    }
}