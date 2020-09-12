using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace whacka_mole
{
    class Mole
    {
        private int _x;
        private int _y;
        private Color _moleColor;
        private const int SIZE = 50;

        /// <summary>
        /// Initialises the object to the given values
        /// </summary>
        /// <param name="x">The x position of the centre of the mole</param>
        /// <param name="y">The y position of the centre of the mole</param>
        /// <param name="moleColor">The colour of the mole</param>
        public Mole(int x, int y, Color moleColor)
        {
            _x = x;
            _y = y;
            _moleColor = moleColor;
        }

        /// <summary>
        /// Gets all the information about a mole
        /// </summary>
        /// <returns>All the information as a neatly padded out string</returns>
        public override string ToString()
        {
            return _x.ToString().PadRight(5) + _y.ToString().PadRight(5) + _moleColor.ToString();
        }
    }
}
