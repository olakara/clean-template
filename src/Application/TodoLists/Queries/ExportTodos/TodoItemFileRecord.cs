using CleanTemplate.Application.Common.Mappings;
using CleanTemplate.Domain.Entities;

namespace CleanTemplate.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
