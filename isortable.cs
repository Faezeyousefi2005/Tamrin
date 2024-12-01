using System;

public interface ISortable
{
    void SortAscending();
    void SortDescending();
}

public class MergeSort : ISortable
{
    private int[] numbers = { 65, 78, 34, 92, 18, 54, 20, 43, 28, 81 };

    public void SortAscending()
    {
        Array.Sort(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }

    public void SortDescending()
    {
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }
}

public class InsertSort : ISortable
{
    private int[] numbers = { 64, 51, 29, 102, 67, 89, 23, 33, 45, 80 };

    public void SortAscending()
    {
        Array.Sort(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }

    public void SortDescending()
    {
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }
}

public class BubbleSort : ISortable
{
    private int[] numbers = { 12, 61, 87, 60, 54, 34, 24, 49, 99, 53 };

    public void SortAscending()
    {
        Array.Sort(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }

    public void SortDescending()
    {
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }
}

public class SelectSort : ISortable
{
    private int[] numbers = { 27, 6, 190, 85, 76, 91, 34, 29, 75, 55 };

    public void SortAscending()
    {
        Array.Sort(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }

    public void SortDescending()
    {
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }
}

class Program
{
    static void Main()
    {
        ISortable mergeSort = new MergeSort();
        ISortable insertSort = new InsertSort();
        ISortable bubbleSort = new BubbleSort();
        ISortable selectSort = new SelectSort();

        Console.WriteLine("Merge Sort Ascending:");
        mergeSort.SortAscending();
        Console.WriteLine("Merge Sort Descending:");
        mergeSort.SortDescending();

        Console.WriteLine("\nInsert Sort Ascending:");
        insertSort.SortAscending();
        Console.WriteLine("Insert Sort Descending:");
        insertSort.SortDescending();

        Console.WriteLine("\nBubble Sort Ascending:");
        bubbleSort.SortAscending();
        Console.WriteLine("Bubble Sort Descending:");
        bubbleSort.SortDescending();

        Console.WriteLine("\nSelect Sort Ascending:");
        selectSort.SortAscending();
        Console.WriteLine("Select Sort Descending:");
        selectSort.SortDescending();
    }
}