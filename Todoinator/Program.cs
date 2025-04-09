using System.Runtime.CompilerServices;

Console.WriteLine("Willkommen beim Todoinator!");

var todoList = new List<TodoItem>();
while (true)
{
    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"Index {i + 1}: {todoList[i]}");
    }
    Console.WriteLine("""
    1. Neues Todo
    2. Todo abhaken
    """);
    var userMenuChoice = Console.ReadLine();
    switch (userMenuChoice)
    {
        case "1":
            // Todo erstellen
            Console.WriteLine("was ist Todo");
            var todoDescription = Console.ReadLine();
            Console.WriteLine("""
            Wie wichtig?
            1 => Hohe Prio
            2 => Normale Prio
            3 => Niedrige Prio
            """);
            var todoPrio = Console.ReadLine();
            var newToDo = new TodoItem();
            newToDo.Description = todoDescription;
            newToDo.Prio = Convert.ToInt32 (todoPrio);
            todoList.Add(newToDo);
            break;
        case "2":
            // Todo abhaken
            Console.WriteLine("Welches ToDo möchtest du löschen?");
            var indexToDelete = Convert.ToInt32(Console.ReadLine());
            todoList.RemoveAt(indexToDelete - 1);
            break;
        default:
            // Nicht definierter Input eg. "hamster"
            break;
    }
    Console.Clear();
}