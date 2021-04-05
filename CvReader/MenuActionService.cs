using System;
using System.Collections.Generic;
using System.Text;

namespace CvReader
{
    public class MenuActionService
    {
        private List<MenuAction> menuActions;
        public void AddNewAction(int id, string name, string menuName)
        {
            MenuAction menuAction = new MenuAction()
            {
                Id = id,
                Name = name,
                MenuName = menuName

            };
            menuActions.Add(menuAction);
        }
        public List<MenuAction> GetMenuActions(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuActtion in menuActions)
            {
                if(menuActtion.MenuName == menuName)
                {
                    result.Add(menuActtion);
                }
            }
            return result;
        }
            

    }
}
