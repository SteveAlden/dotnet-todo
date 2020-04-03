using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain;

namespace Todo.Api.Controllers
{
    [Route("api/todos")]
    public class TodoController : Controller
    {
        private readonly TodoManager todoManager;

        public TodoController()
        {
            todoManager = new TodoManager();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(todoManager.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(todoManager.Get(id));
        }

        [HttpDelete]
        public void Delete()
        {
            todoManager.Delete();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            todoManager.Delete(id);
        }

        [HttpPost]
        public IActionResult Post(Todos todo)
        {
            return Ok(todoManager.Post(todo));
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody]Todos todo)
        {
            todo.Id = id;
            return Ok(todoManager.Patch(todo));
        }
    }
}
