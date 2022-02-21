namespace Codex.Base.Game
{
    public class Game
    {
        public enum State
        {
            Idle,
            Loading,
            Loaded,
            GameStarting,
            GameStarted,
            LevelStarting,
            LevelStarted,
            GamePlaying,
            LevelEnding,
            LevelEnded,
            GameEnding,
            GameEnded,
            GamePausing,
            GameUnPausing,
            ShowingLevelResults,
            ShowingGameResults,
            RestartingLevel,
            RestartingGame
        };
    }
}