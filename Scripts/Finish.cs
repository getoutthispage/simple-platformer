using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("level 2");
        }
    }
}
