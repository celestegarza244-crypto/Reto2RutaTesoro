using System.Collections;

namespace Reto2RutaTesoro
{
    /// <summary>
    /// A singly linked list implemented completely from scratch.
    /// No built-in collection types (List&lt;T&gt;, LinkedList&lt;T&gt;, Queue&lt;T&gt;,
    /// Stack&lt;T&gt;, Dictionary&lt;TKey,TValue&gt;) or arrays are used to store data.
    /// The only real storage is the chain of <see cref="Node"/> objects
    /// linked through their "Next" reference, starting at "Head".
    /// </summary>
    public class SimpleLinkedList : IEnumerable<Node>
    {
        // "Head" is the only stored reference. Everything else is reached
        // by walking Next pointers, exactly as required by the challenge.
        private Node? head;

        public int Count { get; private set; } = 0;

        public bool IsEmpty => head == null;

        /// <summary>
        /// Inserts a new node at the end of the list (tail insertion).
        /// </summary>
        public void InsertAtEnd(int id, string locationName, string clue, int dangerLevel)
        {
            if (Exists(id))
                throw new InvalidOperationException($"A location with ID {id} already exists.");

            Node newNode = new Node(id, locationName, clue, dangerLevel);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            Count++;
        }

        /// <summary>
        /// Inserts a new node at the beginning of the list (head insertion).
        /// </summary>
        public void InsertAtBeginning(int id, string locationName, string clue, int dangerLevel)
        {
            if (Exists(id))
                throw new InvalidOperationException($"A location with ID {id} already exists.");

            Node newNode = new Node(id, locationName, clue, dangerLevel);
            newNode.Next = head;
            head = newNode;

            Count++;
        }

        /// <summary>
        /// Traverses the list from Head to null looking for a node with the given Id.
        /// Returns the node itself (not a copy) so its data can be read or modified.
        /// </summary>
        public Node? Search(int id)
        {
            Node? current = head;
            while (current != null)
            {
                if (current.Id == id)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        private bool Exists(int id) => Search(id) != null;

        /// <summary>
        /// Finds the node with the given Id and updates its fields in place.
        /// Returns false if no node with that Id exists.
        /// </summary>
        public bool Modify(int id, string newName, string newClue, int newDangerLevel)
        {
            Node? node = Search(id);
            if (node == null)
            {
                return false;
            }

            node.LocationName = newName;
            node.Clue = newClue;
            node.DangerLevel = newDangerLevel;
            return true;
        }

        /// <summary>
        /// Removes the node with the given Id by re-linking its neighbors.
        /// Returns false if no node with that Id exists.
        /// </summary>
        public bool Delete(int id)
        {
            if (head == null)
            {
                return false;
            }

            // Special case: the node to delete is the head itself.
            if (head.Id == id)
            {
                head = head.Next;
                Count--;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Id == id)
                {
                    // Skip over the node being deleted.
                    current.Next = current.Next.Next;
                    Count--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Removes every node from the list.
        /// </summary>
        public void Clear()
        {
            head = null;
            Count = 0;
        }

        /// <summary>
        /// Allows the list to be walked with a simple foreach loop
        /// (e.g. "foreach (Node n in route)") without ever exposing or
        /// copying the data into a prohibited collection type. This is a
        /// pure traversal from Head to null, node by node.
        /// </summary>
        public IEnumerator<Node> GetEnumerator()
        {
            Node? current = head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
