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
        GameObject cubeGO = Instantiate(cubePrefabVar);
        Material cubeMat = cubeGO.GetComponent<Renderer>().material;
        cubeMat.color = Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);
        Object.Destroy(cubeGO, 1.5f);
    }
}
