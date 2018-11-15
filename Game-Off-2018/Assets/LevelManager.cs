using System.Collections.Generic;
using System.Linq;
using Assets.Enemy;

namespace Assets
{
    public class LevelManager
    {
        private static Dictionary<int, Dictionary<Enemy.Enemy, int>> _levels;
        private int _currentLevel;

        public LevelManager()
        {
            _levels = new Dictionary<int, Dictionary<Enemy.Enemy, int>>();
            _currentLevel = 1;


            TestLevels();
        }

        public void Advance()
        {
            _currentLevel += 1;
        }


        public void TestLevels()
        {
            var inner = new Dictionary<Enemy.Enemy, int>();
            inner.Add(new Goblin(), 10);

            _levels.Add(1, inner);

            var inner1 = new Dictionary<Enemy.Enemy, int>();

            inner1.Add(new Goblin(), 20);
            _levels.Add(2, inner1);
        }


        public void LoadLevels()
        {
            //From file
        }

        public List<Dictionary<Enemy.Enemy, int>> GetAllEnemies()
        {
            var enemiesForLevel = _levels.Where(n => n.Key == _currentLevel).Select(n => n.Value).ToList();
            return enemiesForLevel;
        }
    }
}