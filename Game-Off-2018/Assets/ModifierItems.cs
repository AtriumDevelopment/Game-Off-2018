namespace Assets
{
    public class ModifierItem
    {
        public enum ItemType
        {
            AttackSpeed,
            AttackRange,
            Damage
        }

        public int modifier;
        public string name;
        public ItemType itemType;
    }
}
