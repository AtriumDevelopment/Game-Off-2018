using System.Collections.Generic;

namespace Assets
{
    public class Modifier
    {
        public int id;

        private List<ModifierItem> modifierItems;

        private int _attackSpeed;
        private int _attackRange;
        private int _damage;


        public void GetTotalModifiers()
        {
            foreach (ModifierItem modifier in modifierItems)
            {

                if (modifier.itemType.GetTypeCode().Equals(ModifierItem.ItemType.AttackRange))
                {
                    _attackSpeed += modifier.modifier;
                }
                if (modifier.itemType.GetTypeCode().Equals(ModifierItem.ItemType.AttackSpeed))
                {
                    _attackSpeed += modifier.modifier;

                }
                if (modifier.itemType.GetTypeCode().Equals(ModifierItem.ItemType.Damage))
                {
                    _damage += modifier.modifier;
                }
            }
        }

        public int GetDamage { get { return _damage; } }
        public int GetAttackSpeed { get { return _attackSpeed; } }
        public int GetAttackRange { get { return _attackRange; } }
    }
}
