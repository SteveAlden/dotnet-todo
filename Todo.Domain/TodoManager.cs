using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Domain
{
    public class TodoManager
    {
        public static List<Todos> todos = new List<Todos>();
        public static int maxId = 0;

        public IEnumerable<Todos> Get()
        {
            return todos;
        }
        public Todos Get(int id)
        {
            return todos.FirstOrDefault(t => t.Id == id);
        }
        public Todos Post(Todos todo)
        {
            if (todo.Id == 0) todo.Id = ++maxId;
            int index = todos.IndexOf(todo);
            if (index != -1)
            {
                todos[index] = todo;
            }
            else
            {
                todos.Add(todo);
            }
            return todo;        
        }
        public Todos Patch(Todos todo)
        {
            var existTodo = todos.FirstOrDefault(t => t.Id == todo.Id);
            existTodo = todo;
            return existTodo;
        }
        public void Delete(int id)
        {
            todos.RemoveAll(t => t.Id == id);
        }

        public void Delete()
        {
            todos.Clear();
        }
    }
}
