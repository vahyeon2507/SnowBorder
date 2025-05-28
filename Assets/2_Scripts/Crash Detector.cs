using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float delayeforeLoading = 1f;
    [SerializeField] private ParticleSystem crashEffect;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            crashEffect.Play();
            Debug.Log("오! 내 머리야!");
            Invoke(nameof(LoadScene), delayeforeLoading);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}