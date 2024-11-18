using System;
using System.Collections.Generic;
using System.Linq;

namespace campus_molndal_2024_oop._05_datatypes.Classes
{
    public class Playlist
    {
        public List<Song> playlist = new List<Song>();

        public void AddSong(Song song)
        {
            playlist.Add(song);
        }

        public int GetTotalLengthInSeconds()
        {
            var totalLength = 0;

            foreach (var song in playlist)
            {
                totalLength += song.DurantionInSeconds;
            }

            return totalLength;
        }

        public void SortByLength()
        {
            playlist.Sort((song1, song2) => song1.DurantionInSeconds.CompareTo(song2.DurantionInSeconds));
        }

        public List<Song> GetAllSongsByArtist(string artist)
        {
            List<Song> newList = new List<Song>();

            foreach (var song in playlist)
            {
                if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                    newList.Add(song);
            }

            return newList;
        }

        public void DeleteSongsByArtist(string artist)
        {
            playlist.RemoveAll(song => song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase));
        }

        public Song GetLongestSong()
        {
            return playlist.OrderByDescending(song => song.DurantionInSeconds).FirstOrDefault();
        }
    }

    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int DurantionInSeconds { get; set; }

        public Song(string title, string artist, int durantionInSeconds)
        {
            Title = title;
            Artist = artist;
            DurantionInSeconds = durantionInSeconds;
        }
    }
}
