using System.Collections.Generic;
using System.Linq;
using Assets.Enemy;

namespace Assets
{
    public class LevelManager
    {
        private static List<List<Enemy.Enemy>> _levels;
        private int _currentLevel;

        public LevelManager()
        {
            _levels = new List<List<Enemy.Enemy>>();
            _currentLevel = 0;


            TestLevels();
        }

        public void Advance()
        {
            _currentLevel += 1;
        }


        public void TestLevels()
        {
            for (int i = 0; i < 100; i++)
            {
                var lvl = new List<Enemy.Enemy>();
                for (int j = 0; j < (i + 1)* 10; j++)
                {
                    lvl.Add(new Goblin(100, 10));
                }
                _levels.Add(lvl);
            }
        }


        public void LoadLevels()
        {
            //From file
        }

        public List<Enemy.Enemy> GetAllEnemies()
        {
            return _levels[_currentLevel];
        }
    }
}