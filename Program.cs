// See https://aka.ms/new-console-template for more information

static List<int> compareTriplets(List<int> a, List<int> b){
    int tempA = 0, tempB = 0;
    for (int i = 0; i < a.Count; i++){
        if (a[i] > b[i]) { tempA++; }
        else if (a[i] < b[i]) { tempB++; } 
    }
    return new List<int> { tempA, tempB };   
}

List<int> a = new List<int>() { 10, 20, 30 };
List<int> b = new List<int>() { 15, 19, 30 };

//List<int> a = Console.ReadLine().Trim().Split(' ').ToList().Select(tempStr => Convert.ToInt32(tempStr)).ToList();
//List<int> b = Console.ReadLine().Trim().Split(' ').ToList().Select(tempStr => Convert.ToInt32(tempStr)).ToList();

List<int> result = compareTriplets(a,b);

result.ForEach(x => Console.Write(x));
