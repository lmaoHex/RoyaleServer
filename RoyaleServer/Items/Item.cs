using RoyaleServer.Items;

namespace RoyaleServer.Items
{
    abstract class Item
    {
        public string m_Name { get; set; } = "Default Item Name";
        public string m_Desc;
        public ItemType m_Type;

        public Item(ItemType type, string name, string desc)
        {
            m_Name = name;
            m_Desc = desc;
            m_Type = type;

            Debug.LogInfo($"Constructed {m_Name} (\"{m_Desc}\")");
        }
    }
}
