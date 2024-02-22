using UnityEngine;


public interface IComponentPool<T> where T : Component
{
    T Get();
    void Return(T component);
}
