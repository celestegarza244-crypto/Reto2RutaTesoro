namespace Reto2RutaTesoro
{
    /// <summary>
    /// Represents a single location ("treasure stop") in the route.
    /// Each node stores its own data and holds a reference to the next
    /// node in the chain, exactly like a classic singly linked list node.
    /// </summary>
    public class Node
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string Clue { get; set; }
        public int DangerLevel { get; set; }

        /// <summary>
        /// Reference to the next node in the route. Null means "end of list".
        /// </summary>
        public Node? Next { get; set; }

        public Node(int id, string locationName, string clue, int dangerLevel)
        {
            Id = id;
            LocationName = locationName;
            Clue = clue;
            DangerLevel = dangerLevel;
            Next = null;
        }
    }
}
