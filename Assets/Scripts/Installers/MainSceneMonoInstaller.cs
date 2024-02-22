using UnityEngine;
using Zenject;


public class MainSceneMonoInstaller : MonoInstaller
{
    [SerializeField] private CoroutineService m_coroutineServiceInstance;

    [Header("Prefabs")]
    [SerializeField] private CellView m_cellViewPrefab;
    [SerializeField] private Transform m_cellSlotPrefab;

    public override void InstallBindings()
    {
        BindServices();
        BindPrefabs();
    }

    private void BindServices()
    {
        Container.Bind<ICoroutineService>().FromInstance(m_coroutineServiceInstance);
    }

    private void BindPrefabs()
    {
        Container.BindFactory<CellView, CellView.Factory>().FromComponentInNewPrefab(m_cellViewPrefab);
        Container.BindFactory<Transform, CellView.SlotFactory>().FromComponentInNewPrefab(m_cellSlotPrefab);
    }
}