// Creates a List<string> containing the names of 3 of your favorite fruits.
List<string> myFavFruits = new List<string> { "Mango", "Banana", "Watermelon" };

//Adds a new fruit to the list.
myFavFruits.Add("Apple");

//Removes one fruit from the list.
myFavFruits.Remove("Mango");

//Prints all fruits in the list using a foreach loop.
Console.WriteLine("Printing all fruits in the list:");
foreach (string fruit in myFavFruits)
{
    Console.WriteLine(fruit);
}

//Creates a Dictionary<int, string> where keys are fruit IDs (1,2,3) and values are the fruit names.
Dictionary<int, string> fruitInDictionary = new Dictionary<int, string>
{
    {1, "Banana" },
    {2, "Watermelon" },
    {3, "Apple"}
};

//Adds a new entry to the dictionary and prints all key-value pairs.
fruitInDictionary.Add(4, "Grapes");

Console.WriteLine("Printing all key-value pairs in the dictionary:");
foreach (var fruitEntry in fruitInDictionary)
{
    Console.WriteLine($"ID: {fruitEntry.Key}, Fruit: {fruitEntry.Value}");
}