using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Signs))]
public class SuspectConstructor : MonoBehaviour
{
    private Signs signs;
    [SerializeField] private GameObject longHair;
    [SerializeField] private GameObject makeUp;
    [SerializeField] private GameObject scar;
    [SerializeField] private GameObject tattoo;
    [SerializeField] private Material[] hairMaterials;
    [SerializeField] private MeshRenderer[] hairMeshes;

    private void OnEnable()
    {
        signs = GetComponent<Signs>();
        ConstructSuspect();
    }

    public void ConstructSuspect()
    {
        longHair.SetActive(signs.longHair);
        makeUp.SetActive(signs.makeUp);
        scar.SetActive(signs.scar);
        tattoo.SetActive(signs.tattoo);
        foreach (MeshRenderer hairMesh in hairMeshes)
        {
            hairMesh.material = signs.hairMaterial;
        }
    }
}
