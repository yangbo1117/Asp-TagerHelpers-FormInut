using System.Collections.Generic;

namespace MvcMovie.Models
{ 
    public class DemoViewModel
    {
        public string TaskName { get; set; } 
        public List<ToDoItem> ToDo { get; set; } = new List<ToDoItem>{
            new ToDoItem { Name = "CN", IsDone = "CHINA" },
            new ToDoItem { Name = "US", IsDone = "USA"},
            new ToDoItem { Name = "CA", IsDone = "Canada"},
        };
    }
}