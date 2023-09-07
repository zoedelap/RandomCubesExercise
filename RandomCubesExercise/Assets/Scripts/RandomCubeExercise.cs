using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCubeExercise : MonoBehaviour
{

    [SerializeField]
    private GameObject cubePrefabVar;

    // Update is called once per frame
    void Update()
    {
        GameObject cube = Instantiate(cubePrefabVar);
        float cubeWidth = Random.Range(0.1f, 1);
        cube.transform.localScale = new Vector3(cubeWidth, cubeWidth, cubeWidth);
        Material cubeMat = cube.GetComponent<Renderer>().material;
        cubeMat.color = Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);
        Object.Destroy(cube, 1.5f);
    }
}
