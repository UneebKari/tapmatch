using System.Diagnostics;
using UnityEngine;


public static class MonoBehaviourExtensions
{
    [Conditional("UNITY_EDITOR")]
    public static void SetName(this GameObject gameObject, string name)
    {
        gameObject.name = name;
    }
}

