//-------------------------------------------------------------------------------------
//	C#中直接使用IEnumerator的例子
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Example_6
{
    public class IteratorExample2 : MonoBehaviour
    {
        void Start()
        {
            SongsOfThe70s song70s = new SongsOfThe70s();
            song70s.AddSong("song title", "song artist", 1974);
            song70s.AddSong("song title2", "song artist2", 1978);

            IEnumerator songsOfThe70sIterator = song70s.GetIterator();
            while (songsOfThe70sIterator.MoveNext())
            {
                SongInfo info = (SongInfo)songsOfThe70sIterator.Current;
                Debug.Log("Song 70s: " + info.ToStringEx());
            }

            SongsOfThe80s song80s = new SongsOfThe80s();
            song80s.AddSong("song title 80s", "song artist 80s", 1985);
            song80s.AddSong("song title2 80s", "song artist2 80s", 1989);
            IEnumerator songsOfThe80sIterator = song80s.GetIterator();
            while (songsOfThe80sIterator.MoveNext())
            {
                SongInfo info = (SongInfo)songsOfThe80sIterator.Current;
                Debug.Log("Song 80s: " + info.ToStringEx());
            }
        }

        public class SongInfo
        {
            public string songName { get; protected set; }

            public string bandName { get; protected set; }

            public int yearReleased { get; protected set; }

            public SongInfo(string songName, string bandName, int yearReleased)
            {
                this.songName = songName;
                this.bandName = bandName;
                this.yearReleased = yearReleased;
            }

            public string ToStringEx()
            {
                return this.songName + " - " + this.bandName + " : " + this.yearReleased.ToString();
            }
        }

        public interface SongIterator
        {
            IEnumerator GetIterator();
        }

        public class SongsOfThe70s : SongIterator
        {
            protected List<SongInfo> bestSongs;

            public SongsOfThe70s()
            {
                bestSongs = new List<SongInfo>();
            }

            public void AddSong(string name, string artist, int year)
            {
                SongInfo song = new SongInfo(name, artist, year);
                bestSongs.Add(song);
            }

            public IEnumerator GetIterator()
            {
                foreach (SongInfo song in bestSongs)
                    yield return song;
                yield break;
            }
        }

        public class SongsOfThe80s : SongIterator
        {
            protected SongInfo[] bestSongs;

            public SongsOfThe80s()
            {
                bestSongs = new SongInfo[0];
            }

            public void AddSong(string name, string artist, int year)
            {
                SongInfo song = new SongInfo(name, artist, year);
                List<SongInfo> newSongs = new List<SongInfo>(bestSongs);
                newSongs.Add(song);
                bestSongs = newSongs.ToArray();
            }

            public IEnumerator GetIterator()
            {
                foreach (SongInfo song in bestSongs)
                    yield return song;
                yield break;
            }
        }
    }
}