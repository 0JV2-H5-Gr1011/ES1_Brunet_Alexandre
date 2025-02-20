using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Terminus : MonoBehaviour
{
    public GameObject targetObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            StartCoroutine(ResetScene());
        }
    }

    private IEnumerator ResetScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
