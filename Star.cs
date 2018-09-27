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
            var windowWidth = Console.WindowWidth;
            var windowHeight = Console.WindowHeight;
            //var _AllowedLength = 0;
            _phase++;
            if (_phase == _phaseChars.Length) _phase = 0;
            if (_x <= 1)
            {
                _speedX = 1;
            }
            if (_x >= windowWidth -1)
            {
                _speedX = -1;
            }

            if (_y <= 1)
            {
                _speedY = 1;
            }
            if (_y >= windowHeight - 1)
            {
                _speedY = -1;
            }

            _x += _speedX;
            _y += _speedY;

            //if (_AllowedLength == 0 && _speedX == 0)
            //{
            //    for (var i = 0; i < _speedX; i++)
            //    {
            //        _speedX--;
            //        _speedX = 1;
            //    }
                
            //}
     
        }
    }
}
