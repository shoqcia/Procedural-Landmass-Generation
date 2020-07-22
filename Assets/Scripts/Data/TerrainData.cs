using System.Collections;
using UnityEngine;

[CreateAssetMenu()]
public class TerrainData : UpdatableData
{
    public bool useFlatShading;
    public bool useFalloff;

    public float uniformScale = 2.5f;
    public float meshHeightMultiplier;
    public AnimationCurve meshHeightCurve;
}
