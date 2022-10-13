using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    private Pool _pool;
    private Vector3 _direction;
    private float _speed;

    public void Constructor(float speed, Vector3 direction, Pool pool)
    {
        _pool = pool;
        _speed = speed;
        _direction = direction;
    }

    private void Update()
    { 
        Move();
        CheckDistance();
    }

    public void Move() =>
        transform.position=Vector3.MoveTowards(transform.position, _direction, _speed * Time.deltaTime); 

    private void CheckDistance()
    {
        if (Vector3.Distance(transform.position, _direction) <= .1f)
            Hight();
    }

    private void Hight()
    {  
        _pool.HightCube(this);
    }
}
