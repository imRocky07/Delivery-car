using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform thingToFollow;

    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
}
}
