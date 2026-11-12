using UnityEngine;

public class GameManager2 : MonoBehaviour
{
     public static GameManager2 instance
    {
        get
        {
            if(m_instance == null)
            {
                m_instance = FindAnyObjectByType<GameManager>();
            }
            return m_instance;
        }
    }
    static GameManager m_instance;
    public void GameOver()
    {
        Application.Quit();
    }
    public void GameOver()
    {
        Application.Quit();
    }
}