using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("오! 내 머리야!");
            Debug.Log("0번씬을 로드합니다.");
            SceneManager.LoadScene(0);
        }
    }
}
