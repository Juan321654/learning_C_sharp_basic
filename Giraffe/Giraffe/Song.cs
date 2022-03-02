namespace Giraffe
{
  class Song
  {
    public string title;
    public string artist;
    public int duration;
    public static int songCount = 0;

    public Song(string aTitle, string aArtist, int aDuration)
    // this is the constructor
    {
      title = aTitle;
      artist = aArtist;
      duration = aDuration;
      songCount++;
    }

    public int getAllSongsCount()
    {
      return songCount;
    }
  }
}