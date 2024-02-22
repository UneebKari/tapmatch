using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using Random = UnityEngine.Random;

public class HudView : MonoBehaviour
{
    public Action<int> onClickBombButton;

    [SerializeField] private TextMeshProAnimatedBinder m_ScoreText;



    [Inject] private GameSettings m_gameSettings;

    private int m_Score;

    public void Initialize()
    {
        m_Score = 0;
        m_ScoreText.SetValue(m_Score);
 
    }

    public void IncreaseMovesAmount()
    {
        m_Score++;
        m_ScoreText.SetValueAnimated(m_Score);
    }
}
