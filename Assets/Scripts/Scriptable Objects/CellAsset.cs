using System;
using UnityEngine;


[Serializable]
public class CellAsset
{
    public Sprite sprite;
    public AnimatorOverrideController overrideController;

    public CellAsset() { }

    public CellAsset(Sprite sprite, AnimatorOverrideController overrideController)
    {
        this.sprite = sprite;
        this.overrideController = overrideController;
    }
}