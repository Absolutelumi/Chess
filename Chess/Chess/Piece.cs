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

        public abstract void drawPiece(SpriteBatch spriteBatch, Texture2D texture, Rectangle rectangle, bool spawn);
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

        public override void drawPiece(SpriteBatch spriteBatch, Texture2D texture, Rectangle rectangle, bool spawn)
        {
            if(spawn == true)
            {
                for (int i = 0; i > 8; i++)
                {
                    spriteBatch.Draw(texture, new Rectangle(-10, 650, 50, 50), Color.White);
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

        public override void drawPiece(SpriteBatch spriteBatch, Texture2D texture, Rectangle rectangle, bool spawn)
        {
            throw new NotImplementedException();
        }
    }
}
