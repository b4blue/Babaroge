using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.scripts.model {
    public class GameModel : IGameModel{

        public GameModel()
        {
        }

        #region IGameModel implementation

        public void Reset()
        {
            score = 0;
            level = 1;
            lives = initLives;
        }

        public int score { get; set; }

        public int lives { get; set; }

        public int initLives { get; set; }

        public int level { get; set; }

        public bool levelInProgress { get; set; }

        #endregion
    }
}