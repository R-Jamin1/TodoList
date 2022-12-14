namespace Todolist.Data
{
    public class TodoService
    {

#if DEBUG
        private List<Todo> _todoList = new List<Todo>()
        {
            new Todo("Faire les courses", true),
            new Todo("Preparer les croques-monsieurs"),
            new Todo("Se régaler")
        };
#else

        private List<Todo> _todoList = new List<Todo>();
#endif

        public async Task<Todo[]> GetTodoAsync()
        {
            return _todoList.ToArray();
        }
    }
}
