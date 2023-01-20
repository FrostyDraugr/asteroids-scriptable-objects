using UnityEngine;

[CreateAssetMenu(fileName = "Asteroid", menuName = "Asteroid", order = 0)]
public class AsteroidSettings : ScriptableObject
{
    [Range(-50, 50)]
    public int AsteroidDamage = 1;
    public Color Color = Color.black;

    [Range(0.1f, 5)]
    public float Scale = 1;

    [Range(0.1f, 5)]
    public float speedMod = 1;
}
