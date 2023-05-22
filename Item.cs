class Item
{
    public string Id { get; }
    public string ItemName { get; set; }
    public bool IsAvailable { get; set; }

    public Item(string id, string name)
    {
        Id = id;
        ItemName = name;
        IsAvailable = true;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"ItemName: {ItemName}");
        Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
    }
}