using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float RotationSpeed = 200.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), RotationSpeed * Time.deltaTime);
    }
}
