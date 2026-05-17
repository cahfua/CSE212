using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities and dequeue once.
    // Expected Result: The item with the highest priority should be returned.
    // Defect(s) Found: The original loop did not check the last item in the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        Assert.AreEqual("High", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: The first item with the highest priority should be returned first.
    // Defect(s) Found: The original code used >= which caused later equal-priority items to be chosen instead of the first one.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 5);

        Assert.AreEqual("First", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue multiple items after adding them.
    // Expected Result: Items should be removed in highest priority order.
    // Defect(s) Found: The original code returned the value but did not remove it from the queue.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: InvalidOperationException should be thrown with the message "The queue is empty."
    // Defect(s) Found: None.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}