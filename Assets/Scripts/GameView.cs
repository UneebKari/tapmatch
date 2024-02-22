using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    [SerializeField] private HudView m_Hud;
    [SerializeField] private GridView m_gridView;
    [SerializeField] private Image m_fadePanelImage;
    [SerializeField] private float m_fadeTimer = 1.0f;

    //Initialising everthing
    public void Initialize()
    {
        //initializing hud
        m_Hud.Initialize();
        //initializing and creating the grid view
        m_gridView.Initialize(new GridController());
        //Assigining score
        m_gridView.onCellsMatch += m_Hud.IncreaseMovesAmount;
        //turning on black screen
        m_fadePanelImage.enabled = true;
        //fading out black screen
        m_fadePanelImage.CrossFadeAlpha(0f, m_fadeTimer, false);
    }
}