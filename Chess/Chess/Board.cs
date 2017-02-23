using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Chess
{
    class Board
    {
        public Pawn pawn = new Pawn();
        public King king = new King();

        public Piece[,] move(Piece[,] destination)
        {
            return destination;
        }

        internal static void Draw()
        {
            
        }
    }
}
