using System;

namespace CvReader
{
    class App
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w programie do oczytywania i zarzadania plikami pdf");
            Console.WriteLine("Wybierz z menu odpowiednia opcję");

            MenuActionService actionService = new MenuActionService();
            actionService =  Initialize(actionService);
            var mainMenu = actionService.GetMenuActions("Main");
            for(var i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}.{mainMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            CvService cvService = new CvService();
            switch (operation.KeyChar)
            {
                case '1':
                     
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                default:
                    Console.WriteLine("Wybrano nie poprawna opcję");
                    break;
            }
          
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add CV", "Main");
            actionService.AddNewAction(2, "Show CV", "Main");
            actionService.AddNewAction(3, "Remove CV", "Main");
            actionService.AddNewAction(4, "Add ststus to CV", "Main");
            actionService.AddNewAction(5, "List of CV", "Main");

            actionService.AddNewAction(1, "Dostarczono", "AddCvSatus");
            actionService.AddNewAction(2, "Rozpatrtywane", "AddCvSatus");
            actionService.AddNewAction(3, "Odrzuczone", "AddCvSatus");
            actionService.AddNewAction(4, "Zakońcozny proces", "AddCvSatus");
            return actionService;
        }
    }
}
