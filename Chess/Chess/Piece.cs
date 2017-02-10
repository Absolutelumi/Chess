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
        public int[] row = {-10, 75, 160, 245, 330, 415, 500};
        public int[] column = {-10, 75, 160, 245, 330, 415, 500};
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
            int originColumn = 0;
            int originRow = 0;

            if(destinationColumn == originColumn && destinationRow == originRow + 1)
            {
                valid = true;
            }

            return valid;
        }

        public override void drawPiece(SpriteBatch spriteBatch, Texture2D texture, bool white)
        {
            for(int i = 0; i > 7; i++)
            {
                if (white == true)
                {
                    spriteBatch.Draw(texture, new Rectangle(column[i], row[1], width, height), Color.WhiteSmoke);
                }
                else
                {
                    spriteBatch.Draw(texture, new Rectangle(column[i], row[6], width, height), Color.White);
                }
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
