using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float DelayTime = 0.5f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            Invoke("ReloadScene", DelayTime);
        }        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
