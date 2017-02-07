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
    abstract class Piece
    {
        public Texture2D texture { get; set; }
        public bool white { get; set; }
        public int row { get; set; }
        public int column { get; set; }

        public abstract bool IsValidMove(Piece[,] board, int destinationRow, int destinationColumn);

        public void drawPiece(SpriteBatch spriteBatch)
        {

        }
    }

    class Pawn : Piece
    {
        
    }

    class King : Piece
    {

    }

    class Queen : Piece
    {

    }

    class Bishop : Piece
    {

    }

    class Rook : Piece
    {

    }

    class Knight : Piece
    {

    }
}
