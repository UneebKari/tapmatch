using UnityEngine;

public class TapMatchInitializer : MonoBehaviour
{
    [SerializeField]
    private GameView m_gameView;

    private void Start()
    {
        //start the game
        m_gameView.Initialize();
    }
}
