using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField]
    private GameObject _objectToInstantiate;

    public void Instantiate(Transform target) {
        Instantiate(_objectToInstantiate, target.position, quaternion.identity);
    }
}
