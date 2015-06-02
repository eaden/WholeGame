﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WholeGame.Core
{
    class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
