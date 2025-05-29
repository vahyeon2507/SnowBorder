using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 2f; // 로딩 지연 시간
    [SerializeField] private ParticleSystem FinishEffect;

    private AudioSource audioSource;
    private bool isFinished = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isFinished)
            {

            isFinished = true;

            FinishEffect.Play();
            audioSource.Play();
            Invoke(nameof(LoadScene), delayBeforeLoading);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

}
    