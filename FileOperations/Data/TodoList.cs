using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations.Data
{
    internal class TodoList
    {
        public Todo[] todos { get; set; }
        public int total { get; set; }
        public int skip { get; set; }
        public int limit { get; set; }
    }

    public class Todo
    {
        public int id { get; set; }
        public string todo { get; set; }
        public bool completed { get; set; }
        public int userId { get; set; }
    }

}
