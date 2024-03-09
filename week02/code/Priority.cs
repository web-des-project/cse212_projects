public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Get the next value from an empty queue
        // Expected Result: The queue is empty
        Console.WriteLine("Test 1");
        _ = new PriorityQueue();
        priorityQueue.Dequeue();
        
        // Defect(s) Found: None.

        Console.WriteLine("---------");

        // Test 2
        // scenario: Create a queue with the following: Aaron[2], Juliette[forever], Adam[2], Kenji[7]
        // Expected Result: Kenji, Aaron, Adam, Juliette.
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Aaron", 2);
        priorityQueue.Enqueue("Juliette", 0); 
        priorityQueue.Enqueue("Adam", 2);
        priorityQueue.Enqueue("Kenji", 7);
        // Console.WriteLine(priorityQueue);
        while (priorityQueue.Length > 0)
        {
            string value = priorityQueue.Dequeue();
            Console.WriteLine(value);
        }
        // Defect(s) Found: In the Dequeue(), the if statement has the priority greater or equal to the current index, instead of just greater than.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}