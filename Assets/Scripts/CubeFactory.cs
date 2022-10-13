using UnityEngine;

public class Factory
{
    private BoxMovement _cubPrefab;

    public Factory(BoxMovement cubPrefab) =>
        _cubPrefab = cubPrefab;

    public BoxMovement CreateBox(Transform parentTransform)
    {
        BoxMovement obj = GameObject.Instantiate(_cubPrefab, parentTransform);
        obj.gameObject.SetActive(false);
        return obj;
    }
}
