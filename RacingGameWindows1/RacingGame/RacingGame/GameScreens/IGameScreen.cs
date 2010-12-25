#region File Description
//-----------------------------------------------------------------------------
// IGameScreen.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace RacingGame.GameScreens
{
    /// <summary>
    /// Game screen helper interface for all game screens of our game.
    /// Helps us to put them all into one list and manage them in our RaceGame.
    /// </summary>
    public interface IGameScreen
    {
        /// <summary>
        /// Run game screen. Called each frame. Returns true if we want to exit it.
        /// </summary>
        bool Render();
    }
}
