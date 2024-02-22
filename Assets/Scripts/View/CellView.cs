using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CellView : MonoBehaviour
{
    public class Factory : PlaceholderFactory<CellView> { }
    public class SlotFactory : PlaceholderFactory<Transform> { }

    [SerializeField] private Image m_mainImage;
    [SerializeField] private Button m_cellButton;
    [SerializeField] private TextMeshProUGUI m_cordinatesText;
    [SerializeField] private Animator m_animatorController;

    public void Initialize(CellModel model, Action<CellModel> onClickCell)
    {
        m_mainImage.sprite = model.sprite;
        m_cellButton.onClick.RemoveAllListeners();
        m_cellButton.onClick.AddListener(() => onClickCell(model));
        m_cordinatesText.text = $"{model.coordinate.x}, {model.coordinate.y}";
        m_animatorController.runtimeAnimatorController = model.overrideController;
        //checking if animation is needed
        if (model.needsToAnimate)
        {
            m_animatorController.Rebind();
            model.needsToAnimate = false;
        }
        else
        {
            m_animatorController.SetTrigger("Idle");
        }
    }
    //play pop animtion
    public void PlayPopAnimation()
    {
        m_animatorController.SetTrigger("Pop");
    }
}
