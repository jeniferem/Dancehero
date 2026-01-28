using System.Xml;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.TextCore.Text;

public class SongManager : MonoBehaviour
{
  [SerializeField]
  private Animator character;
  [SerializeField]
  private UnityEvent onSetsong;
  [SerializeField]
  private UnityEvent onSongCancel;
  [SerializeField]
  private CharacterData characterData;
  [SerializeField]
  private NotesManager notesManager;
  private SongData currentSong;
  public void SetSong(SongData song)
    {
        onSetsong?.Invoke();
        currentSong=song;
    }
    public void PlaySong()
    {
         SoundManager.instance.PlayMusic(currentSong.songName);
         character.Play(currentSong.animationName,0,0f);
         notesManager.StartNoteChart(currentSong.notesConfig, currentSong.speed);
    }
    public void GetReady()
    {
        character.Play(characterData.readyAnimationName, 0, 0f);
    }
    public void StopSong()
    {
        onSongCancel?.Invoke();
        SoundManager.instance.StopMusic();
        character.Play(characterData.idleAnimationName, 0,0f);
    }
}