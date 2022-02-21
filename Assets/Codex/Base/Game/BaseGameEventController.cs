using UnityEngine;
using UnityEngine.Events;
using Codex.Misc;

namespace Codex.Base.Game
{
	[AddComponentMenu("Codex/Base/BaseGameEventController")]
    public class BaseGameEventController : ExtendedMonoBehaviour
    {
	    public Game.State currentGameState;
	    public Game.State targetGameState;
	    public Game.State lastGameState;
	    
        public UnityEvent OnLoaded;

        public UnityEvent OnGameStarting;
        public UnityEvent OnGameStarted;

        public UnityEvent OnLevelStarting;
        public UnityEvent OnLevelStarted;
        public UnityEvent OnLevelEnding;
        public UnityEvent OnLevelEnded;

        public UnityEvent OnGameEnding;
        public UnityEvent OnGameEnded;
        public UnityEvent OnGamePause;
        public UnityEvent OnGameUnPause;

        public UnityEvent OnShowLevelResults;
        public UnityEvent OnShowGameResults;

        public UnityEvent OnRestartLevel;
        public UnityEvent OnRestartGame;

        public virtual void Loaded() { OnLoaded.Invoke(); }
        public virtual void GameStarting() { OnGameStarting.Invoke(); }
        public virtual void GameStarted() { OnGameStarted.Invoke(); }
        public virtual void LevelStarting() { OnLevelStarting.Invoke(); }
        public virtual void LevelStarted() { OnLevelStarted.Invoke(); }
        public virtual void LevelEnding() { OnLevelEnding.Invoke(); }
        public virtual void LevelEnded() { OnLevelEnded.Invoke(); }
        public virtual void GameEnding() { OnGameEnding.Invoke(); }
        public virtual void GameEnded() { OnGameEnded.Invoke(); }
        public virtual void GamePause() { OnGamePause.Invoke(); }
        public virtual void GameUnPause() { OnGameUnPause.Invoke(); }
        public virtual void ShowLevelResults() { OnShowLevelResults.Invoke(); }
        public virtual void ShowGameResults() { OnShowGameResults.Invoke(); }
        public virtual void RestartLevel() { OnRestartLevel.Invoke(); }
        public virtual void RestartGame() { OnRestartGame.Invoke(); }

        public void SetTargetState(Game.State newState)
        {
            targetGameState = newState;
            if (targetGameState != currentGameState)
                UpdateTargetState();
        }
        
		public virtual void UpdateTargetState()
		{
			// we will never need to run target state functions if we're already in this state, so we check for that and drop out if needed
			if (targetGameState == currentGameState)
				return;

			switch (targetGameState)
			{
				case Game.State.Idle:
					break;

				case Game.State.Loading:
					break;

				case Game.State.Loaded:
					Loaded();
					break;

				case Game.State.GameStarting:
					GameStarting();
					break;

				case Game.State.GameStarted:
					GameStarted();
					break;

				case Game.State.LevelStarting:
					LevelStarting();
					break;

				case Game.State.LevelStarted:
					LevelStarted();
					break;

				case Game.State.GamePlaying:
					break;

				case Game.State.LevelEnding:
					LevelEnding();
					break;

				case Game.State.LevelEnded:
					LevelEnded();
					break;

				case Game.State.GameEnding:
					GameEnding();
					break;

				case Game.State.GameEnded:
					GameEnded();
					break;

				case Game.State.GamePausing:
					GamePause();
					break;

				case Game.State.GameUnPausing:
					GameUnPause();
					break;

				case Game.State.ShowingLevelResults:
					ShowLevelResults();
					break;

				case Game.State.ShowingGameResults:
					ShowGameResults();
					break;

				case Game.State.RestartingLevel:
					RestartLevel();
					break;

				case Game.State.RestartingGame:
					RestartGame();
					break;
			}

			// now update the current state to reflect the change
			lastGameState = currentGameState;
			currentGameState = targetGameState;
		}

		public virtual void UpdateCurrentState()
		{
			switch (currentGameState)
			{
				case Game.State.Idle:
					break;

				case Game.State.Loading:
					break;

				case Game.State.Loaded:
					break;

				case Game.State.GameStarting:
					break;

				case Game.State.GameStarted:
					break;

				case Game.State.LevelStarting:
					break;

				case Game.State.LevelStarted:
					break;

				case Game.State.GamePlaying:
					break;

				case Game.State.LevelEnding:
					break;

				case Game.State.LevelEnded:
					break;

				case Game.State.GameEnding:
					break;

				case Game.State.GameEnded:
					break;

				case Game.State.GamePausing:
					break;

				case Game.State.GameUnPausing:
					break;

				case Game.State.ShowingLevelResults:
					break;

				case Game.State.ShowingGameResults:
					break;

				case Game.State.RestartingLevel:
					break;

				case Game.State.RestartingGame:
					break;

			}
		}
        public Game.State GetCurrentState()
        {
            return currentGameState;
        }
    }
}