using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WholeGame.Core
{

    class GameState_Handler
    {
        private static GameState_Handler instance;
        private GameState_Handler() { }
        public static GameState_Handler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameState_Handler();
                    //Console.WriteLine("Ich wurde gerade erschaffen.");
                }
                //else
                    //Console.WriteLine("Ich lebe noch.");
                return instance;
            }
        }
        private SpriteBatch spritebatch;
        private GameStates_Overall GameState_Enum = GameStates_Overall.MenuScreen;

        public void loadContent(ContentManager Content, SpriteBatch spritebatch)
        {
            WholeGame.Core.GUI.Controls_GUI.Instance.loadContent();
            WholeGame.Core.GUI.Screens.Menu_GUI.Instance.loadContent(Content);
            //Die Singletons sollten immer noch den nicht-Singletons initialisiert werden

            this.spritebatch = spritebatch;
            
            
        }

        public void update()
        {
            switch (GameState_Enum)
            {
                case GameStates_Overall.MenuScreen:
                    WholeGame.Core.GUI.Controls_GUI.Instance.update();
                    WholeGame.Core.GUI.Screens.Menu_GUI.Instance.update();
                    break;
                default:
                    break;
            }
        }

        public void draw()
        {
            switch (GameState_Enum)
            {
                case GameStates_Overall.MenuScreen:
                    
                    WholeGame.Core.GUI.Screens.Menu_GUI.Instance.draw(spritebatch);
                    break;
                default:
                    break;
            }
        }
    }
}
