namespace Dung.Array
{
    public class Menu
    {
        public int id { get; set; }
        public string title { get; set; }
        public int parent_id { get; set; }

        public Menu(int id, string name,int parent_id)
        {
            this.id = id;
            this.title = name;
            this.parent_id = parent_id;
        }
    }
}