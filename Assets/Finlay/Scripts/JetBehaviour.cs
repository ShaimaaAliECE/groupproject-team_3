using UnityEngine;

public class JetBehaviour : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f; // Speed of rotation
    public GameObject laserBeam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0, Space.World);

        float rotationVertical = -Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotationVertical, 0, 0, Space.Self);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion spawnRotation = transform.rotation * Quaternion.Euler(90f, 0f, 0f);
            Instantiate(laserBeam, transform.position, spawnRotation);
        }
    }
}
