using UnityEngine;

public class GameHelper : MonoBehaviour
{
    private GameData _gameData;
    private Factory _factory;
    private Pool _pool;
    private float erdy;

    public void Construstor(GameData gameData, Factory factory,Pool pool)
    {
        _gameData = gameData;
        _factory = factory;
        _pool = pool;
        Invoke(nameof(SpawnBox), _gameData.RepitRate);
}

    public void TimerChangeHandler(string arg)
    {
            bool yep=float.TryParse(arg, out erdy);
        if (yep)
            _gameData.RepitRate = erdy;
    }

    public void DirectionChangeHandler(string arg) => 
        _gameData.Direction = Vector3.forward * float.Parse(arg);

    public void SpeedChangeHandler(string arg) => 
        _gameData.Speed = float.Parse(arg);

    private void SpawnBox()
    {
        BoxMovement obj = _pool.GetCube();
        obj.gameObject.SetActive(true);
        obj.transform.parent = null;
        obj.transform.position = Vector3.zero;
        obj.Constructor(_gameData.Speed, _gameData.Direction, _pool);
        Invoke(nameof(SpawnBox), _gameData.RepitRate);
    }

}