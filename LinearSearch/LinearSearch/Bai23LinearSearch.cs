using Dung.Array;
namespace Dung.LinearSearch
{
	public class Bai23LinearSearch
	{
		public void printMenu(List<Menu> menus)
		{
            sortMenubyParent_id(menus);
            var menuDict = new Dictionary<int, List<Menu>>();

            foreach (var menu in menus)
            {
                if (!menuDict.ContainsKey(menu.parent_id))
                {
                    menuDict[menu.parent_id] = new List<Menu>();
                }
                menuDict[menu.parent_id].Add(menu);
            }

            PrintMenuItems(0, menuDict, 0);
        }

        private void PrintMenuItems(int parentId, Dictionary<int, List<Menu>> menuDict, int parentlevel)
        {
            if (menuDict.ContainsKey(parentId))
            {
                foreach (var menu in menuDict[parentId])
                {
                    string ouput = new string('-', parentlevel * 2);
                    Console.WriteLine($"{ouput} {menu.title}");
                    PrintMenuItems(menu.id, menuDict, parentlevel + 1);
                }
            }
        }

        private void sortMenubyParent_id(List<Menu> menus)
        {
            for (int i = 0; i < menus.Count - 1; i++)
            {
                for (int j = 0; j < menus.Count - 1 - i; j++)
                {
                    if (menus[j].parent_id > menus[j + 1].parent_id)
                    {
                        var temp = menus[j];
                        menus[j] = menus[j + 1];
                        menus[j + 1] = temp;
                    }
                }
            }
        }

    }
}