
List<movie> mymovies = new List<movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    movie newMovie = new movie(tempArray[0], tempArray[2]);
    mymovies.Add(newMovie);
}

foreach(movie movie in mymovies)
{
    Console.WriteLine($"One of my favourite movies {movie.Title} was released in {movie.Year}.");
}
static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\thoma\Desktop\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }
    public movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}