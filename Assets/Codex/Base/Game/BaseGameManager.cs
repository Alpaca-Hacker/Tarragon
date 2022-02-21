using System;
using Codex.Misc;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Codex.Base.Game
{
    [AddComponentMenu("Codex/Base/BaseGameManager")]
    public class BaseGameManager : Singleton<BaseGameManager>
    {
        private DateTime _sessionStartTime;
        private DateTime _sessionEndTime;
        
        [Required]
        public BaseGameEventController eventController;

        private void Start()
        {
            _sessionStartTime = DateTime.Now;
            Debug.Log("Game session start: "+ _sessionStartTime);
            eventController = gameObject.GetComponent<BaseGameEventController>();
        }

        private void OnApplicationQuit()
        {
            _sessionEndTime = DateTime.Now;
            var timeDiff = _sessionEndTime.Subtract(_sessionStartTime);
            Debug.Log("Game session end: "+ _sessionEndTime);
            Debug.Log("Game session lasted: "+ timeDiff);
        }
        
        public virtual void PauseGame()
        {
            eventController.OnGamePause.Invoke();
            Paused = true;
        }

        public virtual void UnPausedGame()
        {
            eventController.OnGameUnPause.Invoke();
            Paused = false;
        }

        private bool _paused;
        public bool Paused
        {
            get => _paused;
            set
            {
                _paused = value;
                Time.timeScale = _paused ? 0f : 1f;
            }
        }
    }
}