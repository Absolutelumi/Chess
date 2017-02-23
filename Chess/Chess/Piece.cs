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
    public abstract class Piece
    {
        private Texture2D texture { get; set; }
        protected Color color { get; set; }
        public enum PieceColor { White, Black }
        protected int row { get; set; }
        protected int column { get; set; }
        private readonly int width = 100;
        private readonly int height = 100;

        protected Piece(int row, int column, PieceColor color)
        {
            this.color = color == PieceColor.White ? Color.White : Color.WhiteSmoke; 
        }

        public abstract bool IsValidMove(Piece[,] board, int destinationRow, int destinationColumn);
    }
    
    class Pawn : Piece
    {
        public Pawn() : base() { }

        public override bool IsValidMove(Piece[,] board, int destinationRow, int destinationColumn)
        {
            bool valid = false;

            if(destinationColumn == column && destinationRow == row + 1)
            {
                valid = true;
            }

            return valid;
        }
    }

    class King : Piece
    {
        public override bool IsValidMove(Piece[,] board, int destinationRow, int destinationColumn)
        {
            throw new NotImplementedException();
        }
    }
}
