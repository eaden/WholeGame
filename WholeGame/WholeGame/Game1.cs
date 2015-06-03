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

namespace WholeGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteBatch spriteBatch1;
        public Texture2D background;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteBatch1 = new SpriteBatch(GraphicsDevice);
            //WholeGame.Core.GameState_Handler myGameState = WholeGame.Core.GameState_Handler.Instance;

            //myGameState.loadContent()
            WholeGame.Core.GameState_Handler.Instance.loadContent(Content, spriteBatch);
            background = Content.Load<Texture2D>("background");
            this.IsMouseVisible = true;
            //WholeGame.Core.GUI.Screens.Menu_GUI.Instance.loadContent(Content);



            

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            WholeGame.Core.GameState_Handler.Instance.update();
            //WholeGame.Core.GUI.Screens.Menu_GUI.Instance.update();
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            //spriteBatch1.Begin();
            //spriteBatch1.Draw(background, new Rectangle(0, 0, 800, 480), Color.White);
            //spriteBatch1.End();

            //spriteBatch.Begin();
            //WholeGame.Core.GUI.Screens.Menu_GUI.Instance.draw();
            //spriteBatch.End();
            WholeGame.Core.GameState_Handler.Instance.draw();

            //spriteBatch.Draw(background, new Rectangle(0, 0, 800, 480), Color.White);
            ////spriteBatch.Draw(background, new Rectangle(0, 0, 300, 480), Color.White);
            ////_3DPrototype.GUI.Screens.GUI_Menu.draw();
            //_3DPrototype.GUI.Screens.GUI_Menu.draw(spriteBatch);

            

            base.Draw(gameTime);
        }
    }
}
