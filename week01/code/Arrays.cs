public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Problem Solving Plan:
        // 1. Create a new array of doubles using the provided length.
        // 2. Use a loop to go through each index in the array.
        // 3. Multiply the starting number by the current position plus 1.
        // 4. Store each multiple in the array.
        // 5. Return the completed array of multiples.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Problem Solving Plan:
        // 1. Determine where the rotation should begin by subtracting amount from the list size.
        // 2. Copy the items from that position to the end of the list into a temporary list.
        // 3. Remove those items from the original list.
        // 4. Insert the temporary list at the beginning of the original list.
        // 5. The list is now rotated to the right by the requested amount.

        int startIndex = data.Count - amount;

        List<int> rotatedSection = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, rotatedSection);
    }
}
