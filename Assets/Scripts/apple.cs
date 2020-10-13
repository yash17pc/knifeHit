using UnityEngine;

public class apple : MonoBehaviour
{
    [SerializeField] private ParticleSystem appleParticle;
    private BoxCollider2D myCollider2D;
    private SpriteRenderer sp;

    private void Start()
    {
        myCollider2D = GetComponent<BoxCollider2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("knife")){
            myCollider2D.enabled = false;
            sp.enabled = false;
            appleParticle.Play();
            Destroy(gameObject,2f);
        }
    }
}
