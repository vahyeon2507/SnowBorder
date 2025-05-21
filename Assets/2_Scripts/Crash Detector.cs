using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("��! �� �Ӹ���!");
            Debug.Log("0������ �ε��մϴ�.");
            SceneManager.LoadScene(0);
        }
    }
}
