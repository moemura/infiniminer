﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Plexiglass.Client.States
{
    public interface IStateMachine
    {
        ContentManager Content { get; }
        GraphicsDevice GraphicsDevice { get; }
        bool IsMouseVisible { get; set; }

        bool WindowHasFocus();

        T LoadContent<T>(string assetName);

        void Exit();
        void ChangeState(string newState);
        void CheckForStandingInLava();
    }
}
