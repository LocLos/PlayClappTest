using System.Collections.Generic;
using UnityEngine;

public class Pool
{
    private Stack<BoxMovement> _container = new Stack<BoxMovement>();
    private Transform _parentTransform;
    private Factory _factory;
    private int _startCountBoxes;

    public Pool(Transform parentTransform, Factory factory, int startCountBoxes)
    {
        _parentTransform = parentTransform;
        _factory = factory;
        _startCountBoxes = startCountBoxes;
        FillContainer();
    }

    private void FillContainer()
    {
        for (int i = 0; i < _startCountBoxes; i++)
            _container.Push(CreateBox());
    }

    public BoxMovement GetCube()
    {
        if (_container.Count == 0)
            return CreateBox();
        else
            return _container.Pop();
    }
    public void HightCube(BoxMovement obj)
    {
        _container.Push(obj);
        obj.gameObject.SetActive(false);
        obj.transform.parent = _parentTransform;
    }

    private BoxMovement CreateBox() =>
      _factory.CreateBox(_parentTransform);
}
