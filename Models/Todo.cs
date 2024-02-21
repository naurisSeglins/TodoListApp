namespace TodoListApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string TodoItem { get; set; }
        public bool IsComplete { get; set; }
        public Todo()
        {

        }
    }
}
