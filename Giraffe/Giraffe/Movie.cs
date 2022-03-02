namespace Giraffe
{
  class Movie
  {
    public string title;
    public string director;
    private string rating;

    public Movie(string aTitle, string aDirector, string aRating)
    // this is the constructor
    {
      title = aTitle;
      director = aDirector;
      GetRating = aRating;
    }

    public string GetRating
    {
      get { return rating; }
      set
      {
        if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
        {
          rating = value;
        }
        else
        {
          rating = "NR";
        }
      }
    }
  }
}