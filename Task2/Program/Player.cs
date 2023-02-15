using System;

namespace Program
{
    public class Player
    {
        private int _x;
        private int _y;
        private int _score;
        public int Score { get => _score; }
        public void Move(char pressedKey)
        {
            switch (pressedKey)
            {
                case 'w' when _y > 0:
                    _y--;
                    break;
                default:
                    break;
            }
        }
    }
}
