using System;
using System.Collections.Generic;
public class PickPeaks
{

    static void Main(string[] args)
    {
        int[] arr = new int[] { 3, 2 };
        foreach (var keyValuePair in GetPeaks(arr))
        {
            Console.Write($"{keyValuePair.Key}: ");
            
            foreach (var item2 in keyValuePair.Value)
            {
               Console.Write($"{item2},");
            }
              
            
            
        }     
            
    }
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {

        List<int> peaks = new();
        List<int> positions = new();
       

        Dictionary<string, List<int>> pickedPeaks = new();
        

        for (int i = 1; i < arr.Length; i++)
        {

            int x = 0;
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                peaks.Add(arr[i]);
                positions.Add(i);
               
            }
            else if (arr[i] == arr[i - 1] && arr[i] == arr[i + 1])
            {
                x++;
                if (x == 1)
                {
                    peaks.Add(arr[i]);
                    positions.Add(i - x);
                }
                break;
            }
           
        }
        pickedPeaks.Add("pos", positions);
        pickedPeaks.Add("peaks", peaks);

        return pickedPeaks;
    }
}