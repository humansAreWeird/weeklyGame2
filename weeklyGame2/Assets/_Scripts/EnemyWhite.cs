using UnityEngine;
using System.Collections;

public class EnemyWhite : MonoBehaviour
{

    private Rigidbody rb;
    private int RandomDirection;
    public float speed = 1f;

    void Start(){
        rb.GetComponent<Rigidbody2D>();
}

	void Update () {
        RandomDirection = Random.Range(0, 4);


        switch (RandomDirection)
        {
            case 0:
                break;
            case 1: {
                if (gameObject.transform.position.x >= -8f)
                    gameObject.transform.position += new Vector3(-0.1f * speed, 0);
                break;
                }
            case 2: {
                    if (gameObject.transform.position.x <= 8f)
                        gameObject.transform.position += new Vector3(0.1f * speed, 0);
                    break;
                }
            case 3: {
                    if (gameObject.transform.position.y >= -6.5f)
                        gameObject.transform.position += new Vector3(0, -0.1f * speed);
                    break;
                }
            case 4: {
                    if (gameObject.transform.position.y <= 6.5f)
                        gameObject.transform.position += new Vector3(0, 0.1f * speed);
                    break;
                }
        }
	}
}
