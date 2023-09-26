using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject objects;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObjects", 1, 2);
    }

    // Update is called once per frame
    void CreateObjects()
    {
        Instantiate(objects, new Vector3(12f, 0f, 0), Quaternion.identity);
    }
}
