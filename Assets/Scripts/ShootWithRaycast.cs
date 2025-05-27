using UnityEngine;

public class ShootWithRaycast : MonoBehaviour
{
    [SerializeField] private float raycastLength;
    [SerializeField] private GameObject ShootPosition;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, raycastLength))
            {
                Instantiate(ShootPosition, hit.point, Quaternion.identity);
            }
        }
        Debug.DrawRay(transform.position, transform.forward * raycastLength, Color.red);
    }
}
