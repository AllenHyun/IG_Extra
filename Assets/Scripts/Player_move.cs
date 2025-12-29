using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody body;
    [SerializeField] private float speed;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor_axis = Input.GetAxis("Horizontal");
        float ver_axis = Input.GetAxis("Vertical");
        body.AddForce(new Vector3(hor_axis, 0, ver_axis)*speed*Time.deltaTime);
    }
}
