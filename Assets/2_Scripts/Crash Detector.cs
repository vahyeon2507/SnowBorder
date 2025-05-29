using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float delayeforeLoading = 1f;
    [SerializeField] private ParticleSystem crashEffect;
    [SerializeField] private AudioClip crashSound;

    private AudioSource audioSource;
    private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            crashEffect.Play();
            audioSource.PlayOneShot(crashSound);
            playerController.GameOver();
            Invoke(nameof(LoadScene), delayeforeLoading);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}