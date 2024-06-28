using UnityEngine;

public class CameraBreathing : MonoBehaviour
{
    public Quaternion min;
    public Quaternion max;
    public float speed = 0.02f;
    public float updateDelay = 0.2f;
    private float time;
    private Quaternion target;
    void Update()
    {
        if(time > updateDelay)
        {
            time = 0f;
            target = new Quaternion(Random.Range(min.x,max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z), Random.Range(min.w, max.w));
        }

        transform.localRotation = Quaternion.Slerp(transform.localRotation, target, speed * Time.deltaTime * Time.timeScale);
        time += Time.deltaTime;
    }
}
