public class Item
{
    //All possible information about a single item:
    public string Name { get; private set; } //name of item
    public string Id { get; private set; } //id of item
    public string Type { get; private set; } //type or category of item
    public string Description { get; private set; } //description of item
    public bool CanDrop { get; private set; } //can the item be dropped?
    public bool Stackable { get; private set; } //can the item be stacked?
    public bool CanGive { get; private set; } //can the item be give to another person?
    public bool CanPlace { get; private set; } //can the item be placed down?
    public bool CanTrash { get; private set; } //can the item be thrown in a trash can?
    public bool CanModify { get; private set; } //can an item be modified? ex. coffee being refilled in a cup

    //Constructor: initialize item-
    public Item(string name, string id, string type, string description, bool canDrop, bool stackable, bool canGive, bool canPlace, bool canTrash, bool canModify) {
        Name = name;
        Id = id;
        Type = type;
        Description = description;
        CanDrop = canDrop;
        Stackable = stackable;
        CanGive = canGive;
        CanPlace = canPlace;
        CanTrash = canTrash;
        CanModify = canModify;
    }
}
