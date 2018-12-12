using UnityEngine;

public class Box : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void Move(float dir)
    {
        speed = dir;
        Destroy(this, 3f);
    }
}
