using UnityEngine;

public class CubeR_O_T_A_T_E : MonoBehaviour
{
    public float rotationSpeed = 30f;
    void Update()
    {
        // Rotate the cube around the y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
