using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Api.Models
{
    public class TaskItem
    {
        public Guid? Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public Guid? TaskListId { get; set; }
    }
}
