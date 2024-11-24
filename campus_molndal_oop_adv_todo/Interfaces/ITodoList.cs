namespace campus_molndal_oop_adv_todo.Interfaces
{
    internal interface ITodoList
    {
        void AddTodo(string description, string createdOn, int isCompleted);
        void DisplayAllTodos();
        void DisplayCompletedTodos();
        void DisplayNotCompletedTodos();
        void UpdateTodo(int id, string description, int isCompleted, string createdOn);
        void DeleteTodo(int id);

    }
}
