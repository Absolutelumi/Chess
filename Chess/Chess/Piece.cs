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
        public int[] row = { -10, 75, 160, 245, 330, 415, 500, 585 };
        public int[] column = { -10, 75, 160, 245, 330, 415, 500, 585 };
        public int width = 100;
        public int height = 100;

        public abstract bool IsValidMove(Piece[,] board, int destinationRow, int destinationColumn);

        public abstract void drawPiece(SpriteBatch spriteBatch, Texture2D texture, bool white);
    }

    class Pawn : Piece
    {
        public override bool IsValidMove(Piece[,] board, int destinationRow, int destinationColumn)
        {
            bool valid = false;

            //valid = destinationColumn == column && destinationRow == row + 1 ? true : false;

            return valid;
        }

        public override void drawPiece(SpriteBatch spriteBatch, Texture2D texture, bool white)
        {
            if(white == true)
            {
                spriteBatch.Draw(texture, new Rectangle(column[0], row[6], width, height), Color.White);
            }
            else
            {
                spriteBatch.Draw(texture, new Rectangle(column[0], row[1], width, height), Color.Black);
            }
        }
    }

    class King : Piece
    {
        public override bool IsValidMove(Piece[,] board, int destinationRow, int destinationColumn)
        {
            throw new NotImplementedException();
        }

        public override void drawPiece(SpriteBatch spriteBatch, Texture2D texture, bool white)
        {
            throw new NotImplementedException(); 
        }
    }
}
