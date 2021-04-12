
using UnityEngine;
[RequireComponent(typeof(Renderer))]
public class Directivas : MonoBehaviour
{
    private float angle = 0;
    [SerializeField] private Material red = null;
    [SerializeField] private Material blue = null;


    void Awake ()
    {
        GetComponent<Renderer>().material = red;
    }
    private void Update()
    {
        angle += 45 * Time.deltaTime;
        if (angle > 360) angle -= 360; 
            transform.rotation = Quaternion.Euler(45, angle,45);

        if (Input.GetKey(KeyCode.Escape)) Application.Quit();
    }

}
