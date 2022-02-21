using System;
using System.Collections.Generic;
using Codex.Misc;
using UnityEngine;

namespace Codex.Player
{
    //Use for managing players in a game
    
    [AddComponentMenu("Codex/Base/BaseUserManager")]
    public class BaseUserManager : ExtendedMonoBehaviour
    {
        public static List<UserData> GlobalUserDataList;

        public void Init()
        {
            GlobalUserDataList ??= new List<UserData>();
            didInit = true;
        }
    
        // Reset all information
        public void ResetUsers()
        {
            if (!didInit)
            {
                Init();
            }

            GlobalUserDataList = new List<UserData>();
        }

        public List<UserData> GetPlayerList()
        {
            if (!didInit)
            {
                Init();
            }

            return GlobalUserDataList;
        }

        public int AddNewPlayer()
        {
            if (!didInit)
            {
                Init();
            }

            var newPlayer = new UserData();
            newPlayer.id = GlobalUserDataList.Count;
            GlobalUserDataList.Add(newPlayer);
            return newPlayer.id;
        }

        public string GetName(int playerId)
        {
            if (GlobalUserDataList[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return string.Empty;
            }

            return GlobalUserDataList[playerId].name;
        }
        
        public void SetName(int playerId, string newName)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return;
            }

            GlobalUserDataList[playerId].name = newName;
        }
        
        public int GetScore(int playerId)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return 0;
            }

            return GlobalUserDataList[playerId].score;
        }
        
        public void SetScore(int playerId, int newScore)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return;
            }

            GlobalUserDataList[playerId].score = newScore;
        }
        
        public void AddScore(int playerId, int amount)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return;
            }

            GlobalUserDataList[playerId].score += amount;
        }
        
        public void ReduceScore(int playerId, int amount)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return;
            }

            GlobalUserDataList[playerId].score -= amount;
        }
        
        public int GetHealth(int playerId)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return 0;
            }

            return GlobalUserDataList[playerId].health;
        }
        
        public void SetHealth(int playerId, int newHealth)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return;
            }

            GlobalUserDataList[playerId].health = newHealth;
        }
        
        public void AddHealth(int playerId, int amount)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return;
            }

            GlobalUserDataList[playerId].health += amount;
        }
        
        public void ReduceHealth(int playerId, int amount)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return;
            }

            GlobalUserDataList[playerId].health -= amount;
        }
        
        public int GetHighScore(int playerId)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return 0;
            }

            return GlobalUserDataList[playerId].highScore;
        }
        
        public void SetHighScore(int playerId, int newScore)
        {
            if (GlobalUserDataList?[playerId] is null)
            {
                Debug.LogError("Player id: "+ playerId +" not found!");
                return;
            }

            GlobalUserDataList[playerId].highScore = newScore;
        }
        
        //Also for lives, isFinished and type
    }
}