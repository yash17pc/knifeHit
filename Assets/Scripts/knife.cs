using UnityEngine;

public class knife : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] private float speed;
    private Rigidbody2D myRigidbody2D;
    public bool isReleased { get; set; }
    public bool hit { get; set; }


   private void Start()
    {
     myRigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            FireKnife();

        }
    }

    public void FireKnife(){

        if (!isReleased){
            isReleased = true;
            myRigidbody2D.AddForce(new Vector2(0f,speed),ForceMode2D.Impulse);
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("wheel")){
            transform.SetParent(other.transform);
            myRigidbody2D.velocity = Vector2.zero;
            myRigidbody2D.isKinematic = true;
        }

        else if (other.gameObject.CompareTag("knife")){
            //GameOver
            //ManagerSound
        }
        
    }
}
