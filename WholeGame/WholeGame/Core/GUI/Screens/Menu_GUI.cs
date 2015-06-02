using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace WholeGame.Core.GUI.Screens
{
    class Menu_GUI
    {
        private static Menu_GUI instance;

        private Menu_GUI() { }

        public static Menu_GUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Menu_GUI();
                }
                return instance;
            }
        }

        public static List<Button_GUI> buttons = new List<Button_GUI>();
        private static MouseState mouseHandle;
        private static MouseState mouseHandle_Old;
        private static string pushed_name = null;
        public static SpriteBatch menuSpritebatch;
        private static Texture2D button_n;
        private static Texture2D button_m;
        private static Texture2D button_p;

        public static void loadContent(ContentManager Content)
        {
            button_n = Content.Load<Texture2D>("button_normal");
            button_m = Content.Load<Texture2D>("button_mouseOver");
            button_p = Content.Load<Texture2D>("button_pressed");

            buttons.Add(new Button_GUI(20, 20, 80, 20, "firstOne"));
            buttons.Add(new Button_GUI(20, 50, 80, 20, "secondOne"));

        }

        public static void update()
        {
            mouseHandle = Controls_GUI.Instance.Mouse_GUI;

            foreach (Button_GUI bb in buttons)
            {
                if (Button_GUI.isInside(mouseHandle.X, mouseHandle.Y, bb.XPos, bb.YPos, bb.Width, bb.Height))
                {

                    if (mouseHandle.LeftButton == ButtonState.Pressed)
                    {
                        
                        if (pushed_name == bb.Name)
                        {
                            bb.Button_State = ButtonState_GUI.Pressed;
                        }
                        if (mouseHandle_Old.LeftButton == ButtonState.Released)
                        {
                            pushed_name = bb.Name;
                        }
                        
                    }
                    else
                        bb.Button_State = ButtonState_GUI.MouseOver;

                    if (mouseHandle.LeftButton == ButtonState.Pressed && mouseHandle_Old.LeftButton == ButtonState.Pressed && pushed_name == bb.Name)
                    {
                        //button.click
                    }  
                    
                    

                }
                else
                    bb.Button_State = ButtonState_GUI.Normal;
                
            }
            mouseHandle_Old = mouseHandle;
        }

        public static void draw(SpriteBatch spritebatch)
        {
            foreach (Button_GUI bb in buttons)
            {
                //menuSpritebatch.Begin();
                //if(bb.Button_State == GUI_ButtonState.Normal)
                //    menuSpritebatch.Draw(button_n, new Rectangle(bb.XPos, bb.YPos, bb.Width, bb.Height), Color.White);
                //if (bb.Button_State == GUI_ButtonState.MouseOver)
                //    menuSpritebatch.Draw(button_m, new Rectangle(bb.XPos, bb.YPos, bb.Width, bb.Height), Color.White);
                //else //(bb.Button_State == GUI_ButtonState.ButtonPressed)
                //    menuSpritebatch.Draw(button_p, new Rectangle(bb.XPos, bb.YPos, bb.Width, bb.Height), Color.White);

                //menuSpritebatch.End();


                if (bb.Button_State == ButtonState_GUI.Normal)
                    spritebatch.Draw(button_n, new Rectangle(bb.XPos, bb.YPos, bb.Width, bb.Height), Color.White);
                else if (bb.Button_State == ButtonState_GUI.MouseOver)
                    spritebatch.Draw(button_m, new Rectangle(bb.XPos, bb.YPos, bb.Width, bb.Height), Color.White);
                else if (bb.Button_State == ButtonState_GUI.Pressed)
                    spritebatch.Draw(button_p, new Rectangle(bb.XPos, bb.YPos, bb.Width, bb.Height), Color.White);
            }

        }
    }
}
