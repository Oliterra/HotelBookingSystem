namespace Hotel.Database.Entities
{
    public class ClientEntity
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int FamilyMembersCount { get; set; }
        public int ClientAge { get; set; }
        public bool HavingChildren { get; set; }
        public int ChildrenAge { get; set; }
        public int ChildrenCount { get; set; }
        public bool HavingPet { get; set; }
        public string PetType { get; set; }
        public bool ClearReputation { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsIncognito { get; set; }
    }
}
