using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Api.Models
{
    public class TaskList
    {
        public Guid? Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? OwnerId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}