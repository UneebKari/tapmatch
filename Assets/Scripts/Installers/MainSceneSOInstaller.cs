using UnityEngine;
using Zenject;


[CreateAssetMenu(fileName = "New Scriptable Object Installer", menuName = "Installers/Scriptable Object Installer")]
public class MainSceneSOInstaller : ScriptableObjectInstaller<MainSceneSOInstaller>
{
    [SerializeField] private GameSettings m_gameSettingsInstance;

    public override void InstallBindings()
    {
        Container.Bind<GameSettings>().FromInstance(m_gameSettingsInstance);
    }
}
