using System.Collections.Generic;
using System.Linq;

namespace Assets
{
    class Specialization
    {
        private List<Modifier> _Modifiers;


        public Specialization()
        {

        }

        public void AddModifier(Modifier modifier)
        {
            _Modifiers.Add(modifier);
        }

        public void RemoveModifier(Modifier modifier)
        {
            _Modifiers.Remove(modifier);
        }

        public void UpdateModifier(Modifier modifier)
        {
            var findModifier = _Modifiers.FirstOrDefault(a => a.Equals(modifier));

            if (findModifier != null)
                findModifier = modifier;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
