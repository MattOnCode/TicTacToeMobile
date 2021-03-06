﻿using System.Collections.Generic;
using TicTacToe.Models;

namespace TicTacToe.Infrastructure
{
    public struct EngineSettings
    {
        public GameType GameType;
        public AiDifficulty Difficulty;
        public int Player1AvatarId;
        public int Player2AvatarId;
        public int BoardSize;
    }

    public struct GameResults
    {
        public bool GameHasWinner;
        public IPlayer Winner;
    }

    public struct EngineTickResult
    {
        public bool SuccessfulTick;
        public bool GameFinished;
        public GameResults Results;
    }

    public enum AiDifficulty
    {
        Easy = 0,
        Medium = 1,
        Hard = 2
    }

    public enum GameType
    {
        Singleplayer = 0,
        Multiplayer = 1
    }

    public interface IGameEngine
    {
        GameType GameType { get; }
        List<BoardCell> Board { get; }
        List<IPlayer> Players { get; }
        AiDifficulty AiDifficulty { get; }

        EngineTickResult TickPlayerTurn(int chosenCell);
        EngineTickResult TickAIPlayerTurn();
    }
}
