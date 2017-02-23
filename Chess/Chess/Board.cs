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
        public Piece[,] board = new Piece[8,8];

        public Piece[,] move(Piece[,] destination)
        {
            return destination;
        }

        public void Draw(SpriteBatch sB)
        {
            foreach(Piece piece in board)
            {
                piece?.drawPiece(sB); 
            }
        }

        private bool isValid()
        {
            bool valid = false;



            return valid; 
        }

        private void setup()
        {
            board[0,0] 
        }
    }
}
