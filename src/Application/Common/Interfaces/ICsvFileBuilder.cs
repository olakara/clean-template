using CleanTemplate.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace CleanTemplate.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
