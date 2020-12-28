using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public enum genre
{
    Rock,
    Metal,
    Country,
    Pop,
    HipHop,
    Rap
}

public class Album
{
    public string nameAlbum;
    public int yearAlbum;

    public Album() { }

    public Album(string name, int year) { nameAlbum = name; yearAlbum = year; }
}

public class Song : Album
{
    string nameSong;
    int yearSong;
    genre genreSong;

    public Song(string name, int year, genre Genre, string nameA, string secondnameA)
    {
        nameAlbum = name;
        yearAlbum = year;
        genreSong = Genre;


    }
}

public class Author : Song
{
    public string nameAuthor;
    public int secondnameAuthor;

    public Author(string nameA, string secondnameA) : base(nameA, secondnameA)
    {

    }

}
