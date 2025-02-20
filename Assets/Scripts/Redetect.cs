using UnityEngine;

public class Redetect : MonoBehaviour
{
    public GameObject targetObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            gameObject.SetActive(false);
        }
    }
}
