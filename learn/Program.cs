// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;
using learn;
using learn.notebook;

internal class Program
{
    public static void Main(string[] args)
    {
        Notebook notebook = new Notebook("readME.md");
        Console.WriteLine("=========ВВЕДИТЕ КОМАНДУ=========\n");
        while (true)
        {
            switch (Console.ReadLine())
            {
                
                case "open":
                {
                    notebook.openFile(Console.ReadLine());
                    break;
                }
                case "save":
                {
                    notebook.saveFile();
                    Console.WriteLine("=========ВВЕДИТЕ КОМАНДУ=========\n");
                    break;
                }
                case "edit":
                {
                    notebook.editFile();
                    Console.WriteLine("=========ВВЕДИТЕ КОМАНДУ=========\n");
                    break;
                }
                case "see":
                {
                    notebook.seeText();
                    Console.WriteLine("=========ВВЕДИТЕ КОМАНДУ=========\n");
                    break;
                }
                case "exit":
                {
                    return;
                }
                default:
                {
                    Console.WriteLine("\n=========СПРАВКА=========");
                    Console.WriteLine("open - открыть файл");
                    Console.WriteLine("see - показать содержимое");
                    Console.WriteLine("edit - редактирование");
                    Console.WriteLine("exit - выход");
                    Console.WriteLine("=========================\n\n");
                    break;
                }
            }
        }
    }
}