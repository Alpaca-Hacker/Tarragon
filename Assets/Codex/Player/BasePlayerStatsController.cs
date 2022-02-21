using Codex.Base.Game;
using Codex.Misc;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Codex.Player
{
    //Use for keeping track of stats for a player
    [RequireComponent(typeof(BaseGameManager))]
    public class BasePlayerStatsController : ExtendedMonoBehaviour
    {
        [Required] public BaseUserManager dataManager;
        public int PlayerId;
        public bool disableAutoPlayerListAdd;

        void Awake()
        {
            Init();
        }

        public virtual void Init()
        {
            SetupDataManager();
            didInit = true;
        }

        public virtual void SetPlayerDetails(int playerId)
        {
            //Called from game manager after add player
            PlayerId = playerId;
        }

        public virtual void SetupDataManager()
        {
            // Not sure if we need all this when the component is required.
            if (dataManager == null)
                dataManager = GetComponent<BaseUserManager>();

            if (dataManager == null)
                dataManager = gameObject.AddComponent<BaseUserManager>();

            if (dataManager == null)
                dataManager = GetComponent<BaseUserManager>();
        }

        public virtual void AddScore(int amount)
        {
            if (!didInit)
            {
                Init();
            }

            dataManager.AddScore(PlayerId, amount);
        }

        public virtual void SetScore(int amount)
        {
            if (!didInit)
            {
                Init();
            }

            dataManager.SetScore(PlayerId, amount);
        }

        public virtual int GetScore()
        {
            if (!didInit)
            {
                Init();
            }

            return dataManager.GetScore(PlayerId);
        }
        
        public virtual void SetHighScore(int newScore)
        {
            if (!didInit)
            {
                Init();
            }

            dataManager.SetHighScore(PlayerId, newScore);
        }

        public virtual int GetHighScore()
        {
            if (!didInit)
            {
                Init();
            }

            return dataManager.GetHighScore(PlayerId);
        }

        public virtual void ReduceScore(int amount)
        {
            if (!didInit)
            {
                Init();
            }

            dataManager.ReduceScore(PlayerId, amount);
        }

        public virtual void AddHealth(int amount)
        {
            if (!didInit)
            {
                Init();
            }

            dataManager.AddHealth(PlayerId, amount);

        }

        public virtual void SetHealth(int amount)
        {
            if (!didInit)
            {
                Init();
            }

            dataManager.SetHealth(PlayerId, amount);

        }

        public virtual int GetHealth()
        {
            if (!didInit)
            {
                Init();
            }

            return dataManager.GetHealth(PlayerId);
        }

        public virtual void ReduceHealth(int amount)
        {
            if (!didInit)
            {
                Init();
            }

            dataManager.ReduceHealth(PlayerId, amount);

        }
        
        //Repeat for lives, name, etc
    }
}