using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[] { "Task 1", "Task 2", "Task 3" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult updateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult deleteTask()
        {
            var somethingWentWrong = true;
            if (somethingWentWrong)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
