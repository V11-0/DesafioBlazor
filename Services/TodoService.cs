using DesafioBlazor.Models;

namespace DesafioBlazor.Services;

public interface ITodoService {
    IList<Todo> GetTodos();
    void CreateTodo(Todo todo);
    void DeleteTodo(Todo todo);
}

public class TodoService : ITodoService
{
    private IList<Todo> todos = new List<Todo>();

    public void CreateTodo(Todo todo)
    {
        todos.Add(todo);
    }

    public void DeleteTodo(Todo todo)
    {
        todos.Remove(todo);
    }

    public IList<Todo> GetTodos()
    {
        return todos;
    }
}