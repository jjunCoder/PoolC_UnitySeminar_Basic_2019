using UnityEngine;

namespace complete
{
    public class PlayerScript : MonoBehaviour
    {
        public GameObject gameOverImage;

        public float kickForce_X = 100.0f;
        public float kickForce_Y = 100.0f;
        public float imageTime = 1.0f;

        Rigidbody2D rb2d;
        Animator anim;
        Transform playerDieAnimObject;
        AudioSource[] sounds;
        AudioSource dieAudio;
        AudioSource wingAudio;


        // Start is called before the first frame update
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            playerDieAnimObject = transform.GetChild(0);
            playerDieAnimObject.gameObject.SetActive(false);
            sounds = GetComponents<AudioSource>();
            dieAudio = sounds[0];
            wingAudio = sounds[1];
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.AddForce(new Vector2(1 * kickForce_X , 1 * kickForce_Y));
                anim.Play("PlayerFlap");
                wingAudio.Play();
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            rb2d.freezeRotation = true;
            playerDieAnimObject.gameObject.SetActive(true);
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            dieAudio.Play();
            anim.Play("PlayerDie");
            gameOverImage.SetActive(true);
        }
    }
}