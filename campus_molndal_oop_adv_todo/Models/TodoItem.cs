namespace campus_molndal_oop_adv_todo.Models
{
    internal class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string CreatedOn { get; set; }
        public int IsCompleted { get; set; }
    }
}
