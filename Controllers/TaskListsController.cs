using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Api.Models;

namespace TaskManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskListsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            // TODO: Get task lists from database and return them
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            // TODO: Get task list by id from database and return it
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(TaskList taskList)
        {
            // TODO: Save task list to database and return it
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(Guid id, TaskList taskList)
        {
            // TODO: Update task list by id in database and return NoContent or NotFound if it doesn't exist
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            // TODO: Delete task list by id from database and return NoContent or NotFound if it doesn't exist
            throw new NotImplementedException();
        }
    }
}