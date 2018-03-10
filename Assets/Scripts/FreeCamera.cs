using UnityEngine;

public class FreeCamera : MonoBehaviour {

    /// <summary>
    /// Coordonatele
    /// </summary>
    public float up = 0.0f;
    public float down = 0.0f;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void FixedUpdate () {
        transform.Translate(Input.GetAxis("Horizontal") != 0? (Input.GetAxis("Horizontal") + 10): Input.GetAxis("Horizontal"), 0, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") != 0 ? (Input.GetAxis("Vertical") + 10) : Input.GetAxis("Vertical"));
        up += 2 * Input.GetAxis("Mouse X");
        down -= 2 * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(down, up, 0);
    }
}
