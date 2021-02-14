using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class FryDoneness : MonoBehaviour
{
    [SerializeField] float doneness = 10;

    void Update()
    {
        CheckDoneness();
    }

    void CheckDoneness()
    {
        if(doneness <= 6f && doneness > 3f)
        {
            FryCookedColor();
        }
        else if(doneness <= 3)
        {
            FryBurnedColor();
        }
    }
    private void FryCookedColor()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        Color cooked = new Color32(219, 172, 53, 1);
        meshRenderer.material.color = cooked;
    }

    private void FryBurnedColor()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        Color burned = new Color32(31, 24, 8, 1);
        meshRenderer.material.color = burned;
    }

}
