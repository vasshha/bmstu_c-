//variant f variant 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;


public enum genre
{
    Rock,
    Metal,
    Country,
    Pop,
    HipHop,
    Rap
}
[DataContract]
public class Album
{
    [DataMember]
    public string nameAlbum;
    [DataMember]
    public int yearAlbum;

    public Album() { }

    public Album(string name, int year) { nameAlbum = name; yearAlbum = year; }

    public void DataContractJsonSerializerAlbum() {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Album));
        MemoryStream stream = new MemoryStream();
        XmlWriter writer = new XmlTextWriter("Album.xml", null);
    }
}
[DataContract]
public class Song : Album
{
    [DataMember]
    string nameSong;
    [DataMember]
    int yearSong;
    genre genreSong;

    public Song(string name, int year, genre Genre, string nameA, string secondnameA)
    {
        nameAlbum = name;
        yearAlbum = year;
        genreSong = Genre;


    }
    public void DataContractJsonSerializerSong()
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Album));
        MemoryStream stream = new MemoryStream();
        XmlWriter writer = new XmlTextWriter("Song.xml", null);
    }
}
[DataContract]
public class Author : Song
{
    [DataMember]
    public string nameAuthor;
    [DataMember]
    public int secondnameAuthor;

    public Author(string nameA, string secondnameA) : base(nameA, secondnameA)
    {

    }
    public void DataContractJsonSerializerAuthor()
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Album));
        MemoryStream stream = new MemoryStream();
        XmlWriter writer = new XmlTextWriter("Author.xml", null);
    }
}




