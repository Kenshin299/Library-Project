class Member : Item
{
    public string Name { get; }

    public Member(string name, string memberId) : base(memberId, "Member")
    {
        Name = name;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Name: {Name}");
    }
}