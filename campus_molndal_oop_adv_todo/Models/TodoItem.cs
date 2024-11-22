using System;

namespace campus_molndal_oop_adv_todo.Models
{
    internal class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsCompleted { get; set; }
    }
}
