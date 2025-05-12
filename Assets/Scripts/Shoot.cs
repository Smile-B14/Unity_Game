using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawnPositions;
    public float shootForce = 2000;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           GameObject bulletClone = Instantiate(bullet, bulletSpawnPositions.position, Quaternion.identity);
            bulletClone.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
            //bulletClone.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
