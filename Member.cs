class Member
{
    public string Name { get; }
    public string MemberId { get; }
    public Member(string name, string memberId)
    {
        Name = name;
        MemberId = memberId;
    }
}