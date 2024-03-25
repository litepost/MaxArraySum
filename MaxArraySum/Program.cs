// https://www.youtube.com/watch?v=n9F9wQD3Mhc
// Find largest sum of non-adjacent numbers


using System.Runtime.InteropServices;

int FindMaxSubsetSum(List<int> input) {
    if (input.Count == 0) return 0;
    if (input.Count == 1) return input[0];

    List<int> maxList = [];
    
    maxList.Add(input[0]);
    maxList.Add(Math.Max(input[0], input[1]));

    for (int i = 2; i < input.Count; i++) {
        maxList.Add(Math.Max(Math.Max(input[i], input[i] + maxList[i-2]), maxList[i-1]));
    }

    return maxList.Last();
}

// List<int> entryArray = [3, 5, -7, 8, 10];
// List<int> entryArray = [3];
List<int> entryArray = [-7, 5, 10];

Console.WriteLine(FindMaxSubsetSum(entryArray));
