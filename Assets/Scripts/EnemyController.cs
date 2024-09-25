using UnityEngine;
public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }

    public void GotHit()
    {
        Debug.Log("Got Hit");
        animator.SetTrigger("GotHit");
        hitParticles.Play();
        audioSource.Play();
        GameManager.Instance.IncrementScore();
    }
}
