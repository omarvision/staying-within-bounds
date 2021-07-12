using UnityEngine;
using UnityEngine.UI; //for Text

public class Move : MonoBehaviour
{
    public float MoveSpeed = 5.0f;
    public Text txtDebug = null;
    private float horz;
    private float vert;

    private void Update()
    {
        //wasd -or- arrows
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        this.transform.Translate(Vector3.right * horz * MoveSpeed * Time.deltaTime);
        this.transform.Translate(Vector3.forward * vert * MoveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        txtDebug.text = "Enter";
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bound") == true)
        {
            txtDebug.text = "Exit";
            this.transform.Translate(Vector3.right * -horz);
            this.transform.Translate(Vector3.forward * -vert);
        }

    }
}