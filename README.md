# Shadify.cs
Web-API for [shadify.yurace.pro](https://shadify.yurace.pro) a powerful REST API service provides a collection of different puzzle types, like crosswords, Sudoku, word search and so on

## Example
```cs
using ShadifyApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new Shadify();
            string cards = await api.GetAllSetCards();
            Console.WriteLine(cards);
        }
    }
}
```
