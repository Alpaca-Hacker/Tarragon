namespace Codex.Player
{
    [System.Serializable]
    public class UserData
    {
        public int id;
        public string name = "Anonymous";
	      
        public int score = 0;
        public int highScore = 0;
        public int level = 1;
        public int health = 100;
        public int lives = 3;
        public bool isFinished= false;
    }
}