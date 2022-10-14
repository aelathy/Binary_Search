// Binary Search
#nullable disable
Console.Clear();

// List<Object> mynums = new List<Object> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };
// List<Object> cars = new List<Object> { "Volvo", "BMW", "Ford", "Ram", "Subaru", "Hyundai", "Honda" };
var mynums = new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };

var cars = new[] { "Volvo", "BMW", "Ford", "Ram", "Subaru", "Hyundai", "Honda" };
// var cars = new List<string> { "Volvo", "BMW", "Ford", "Ram", "Subaru", "Hyundai", "Honda" };




static int binarySearch<T>(IList<T> aList, T item) where T : IComparable
{
    var lIndex = 0;
    var hIndex = aList.Count - 1;

    while (lIndex < hIndex)
    {
        var mIndex = (int)Math.Floor(((lIndex + hIndex) / 2.0));
        var compare = item.CompareTo(aList[mIndex]);
        if (compare == 0)
        {
            return mIndex;
        }
        else if (compare == -1)
        {
            hIndex = mIndex - 1;
        }
        else
        {
            lIndex = mIndex + 1;
        }
    }
    return -1;

}

Console.WriteLine(binarySearch(cars, "Ram"));
Console.WriteLine(binarySearch(mynums, 30));

