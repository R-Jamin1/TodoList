namespace Todolist.Data
{
    public class Todo
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentNullException("Valeur incorrecte pour le titre."); }
                _title = value;
            }
        }
        public string Description { get; set; }



        public Todo(string title, string description = "")
        {
            Title = title;
            Description = description;
        }
    }
}
