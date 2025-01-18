using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform target;
    [SerializeField]private float speed;


    void Update()
    {
        // Rotate around the first paremeter target position
        // Rotate around needs second parameter about the axis or rotation

        transform.RotateAround(target.transform.position,target.transform.up,-speed);
    }
}
