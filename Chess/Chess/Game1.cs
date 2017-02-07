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
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        #region
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;
        Texture2D chessBoard;
        Texture2D chesswallpaper;
        Texture2D pawn;
        Texture2D knight;
        Texture2D rook;
        Texture2D bishop;
        Texture2D king;
        Texture2D queen;
        Rectangle piecePosition;

        int moveVal = 90;

        bool gameStart = false;
        #endregion

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Setting up base game window
        /// </summary>
        protected override void Initialize()
        {
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 720;
            graphics.ApplyChanges();

            IsFixedTimeStep = false; 
            IsMouseVisible = true;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            chesswallpaper = Content.Load<Texture2D>("chess-background");
            font = Content.Load<SpriteFont>("font");
            chessBoard = Content.Load<Texture2D>("chess-board");
            pawn = Content.Load<Texture2D>("chess_piece_pawn");
            rook = Content.Load<Texture2D>("chess_piece_rook");
            bishop = Content.Load <Texture2D>("chess_piece_bishop");
            knight = Content.Load<Texture2D>("chess_piece_knight");
            king = Content.Load<Texture2D>("chess_piece_king");
            queen = Content.Load<Texture2D>("chess_piece_queen");

            spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        // TODO: Add leaderboards
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && gameStart == false)
                gameStart = true;

            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (mouseState.LeftButton == ButtonState.Pressed && piecePosition.Contains(mousePosition))



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            if (gameStart == false)
            {
                spriteBatch.Draw(chesswallpaper, new Rectangle(0, 0, 720, 720), Color.White);

                spriteBatch.DrawString(font, "Chess", new Vector2(240, 30), Color.White, 0, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0.5f);
                spriteBatch.DrawString(font, "Space to start", new Vector2(220, 400), Color.White, 0, new Vector2(0, 0), 0.5f, SpriteEffects.None, 0.5f);
            }

            else
            {
                spriteBatch.Draw(chessBoard, new Rectangle(0, 0, 720, 720), Color.White);
            }
            spriteBatch.End();       

            base.Draw(gameTime);
        }
    }
}
