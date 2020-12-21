using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour
{
    public Material m_Material;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(deployMine());
        m_Material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator deployMine()
    {
        yield return new WaitForSecondsRealtime(3);
        m_Material.color = Color.yellow;
    }
}