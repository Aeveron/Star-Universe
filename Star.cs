using System;

namespace ConsoleStars
{
    public class Star
    {
        private const string _phaseChars = " .x*x.";
        private int _x;
        private int _y;
        private int _speedX;
        private int _speedY;
        private int _phase;

        public Star(int x, int y, int phase, int speedX, int speedY)
        {
            _x = x;
            _y = y;
            _phase = phase;
            _speedX = speedX;
            _speedY = speedY;
        }

        public void Show()
        {
            Console.CursorLeft = _x;
            Console.CursorTop = _y;
            Console.Write(_phaseChars[_phase]);
        }

        public void Update()
        {
            _phase++;
            if (_phase == _phaseChars.Length) _phase = 0;
            _x += _speedX;
            _y += _speedY;
        }
    }
}
