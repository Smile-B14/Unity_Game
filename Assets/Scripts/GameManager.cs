using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject originalGameobject;
    public Transform spawnPosition;
    public Transform parentTransform;
    void Start()
    {
        var cloneGameObject = Instantiate(originalGameobject, spawnPosition.position, Quaternion.identity);
        cloneGameObject.transform.parent = parentTransform;
    }
}
