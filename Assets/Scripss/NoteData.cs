using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoteData
{
    public float spawnTime;
    public int laneIndex;
}
[System.Serializable]
public class NoteChart
{
    public List<NoteData> notes;
}
