using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                    Console.WriteLine("Ich wurde gerade erschaffen.");
                }
                else
                    Console.WriteLine("Ich lebe noch.");
                return instance;
            }
        }

        private GameStates_Overall GameState_Enum = GameStates_Overall.MenuScreen;

        public void loadContent()
        {
            //Vielleicht alles ueber eigene Create-Methode in den Singletons
            //Die Singletons sollten immer noch den nicht-Singletons initialisiert werden
            
            //WholeGame.Core.GUI.Controls_GUI controls_GUI = WholeGame.Core.GUI.Controls_GUI.Instance;
            //WholeGame.Core.GUI.Controls_GUI.Instance.loadContent();
            Console.WriteLine("Test test. lol");
            
        }

        public void update()
        {
            //switch (switch_on)
            //{
            //    default:
            //}
        }
           
        
    }
}
