using System;
using Todo.Domain;
namespace Todo.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var todoManager = new TodoManager();
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Add todo");
            var c = 1;
            while (c != 5)
            {

                var todo = Console.ReadLine();
                var todos = new Todos { Id = c, Title = todo};
                todoManager.Post(todos);
                c += 1;
                

            }
            var t = todoManager.Get();
            foreach(var i in t)
            {
                Console.WriteLine(i.Title);
            }
            

        }
    }
}
