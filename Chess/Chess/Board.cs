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
        public Piece[,] board = new Piece[8, 8];
        Pawn pawn = new Pawn();
        King king = new King();
        Queen queen = new Queen();
        
        public void movePawn()
        {


            if(pawn.IsValidMove() == true)
            {

            }
        }
    }
}
