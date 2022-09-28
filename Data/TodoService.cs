namespace Todolist.Data
{
    public class TodoService
    {

#if DEBUG
        private List<Todo> _todoList = new List<Todo>()
        {
            new Todo("Faire les courses", "Acheter du pain de mie, du fromage et du jambon"),
            new Todo("Preparer les croques-monsieurs", "Cuisson 10 min a 180°"),
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
