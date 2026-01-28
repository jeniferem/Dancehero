using UnityEngine;

public class Lane : MonoBehaviour
{
   [SerializeField]
   private Transform notesPivot;   
   [SerializeField]
   private GameObject noteprefab;
   public GameObject NotePrefab => noteprefab;
   public Transform NotesPivot => notesPivot;
}
