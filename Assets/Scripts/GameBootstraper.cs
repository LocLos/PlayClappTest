using UnityEngine;

public class GameBootstraper : MonoBehaviour
{
    [SerializeField]
    private BoxMovement _cubPrefab;

    [SerializeField]
    private Transform _parentTransform;

    [SerializeField]
    private GameData _gameData; 

    [SerializeField]
    private GameHelper _gameHelper;

    private Factory _factory;
    private Pool _pool;

    private void Awake() =>
        Init();

    private void Init()
    {

        _factory = new Factory(_cubPrefab);
        _pool = new Pool(_parentTransform, _factory, _gameData.StartCountBoxes);
         _gameHelper.Construstor(_gameData,_factory,_pool);
    }


}
