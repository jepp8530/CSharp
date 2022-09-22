//Un-comment below code and fix the issues
//Push to github

Console.WriteLine("How many fibonacci bumbers do you want?");


int loops = int.Parse(Console.ReadLine());

int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    
    int next = first + second;
    first = second;
    second = next;
    
    if(count == 0) {
        return next;
    
    }else{
        return RecursiveFibonacci(first, second, count);
    }
}

int lastFibo = RecursiveFibonacci(1,1,loops);
Console.WriteLine("Last fibonacci number was " + lastFibo);
Console.ReadLine();


