using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoService
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test 1",
                Discription = "Test description 1",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test 2",
                Discription = "Test description 2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.Completed
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Test 3",
                Discription = "Test description 3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(6),
                Status = TodoStatus.New
            };
            todos.Add(todo3);

            return todos;
        }
    }
}
