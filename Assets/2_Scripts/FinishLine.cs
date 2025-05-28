using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 2f; // �ε� ���� �ð�
    [SerializeField] private ParticleSystem FinishEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            {
            FinishEffect.Play();
            Invoke(nameof(LoadScene), delayBeforeLoading);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

}
    