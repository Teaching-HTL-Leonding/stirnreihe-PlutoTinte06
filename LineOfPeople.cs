using System.Text;

namespace Stirnreihe.Data;

public class LineOfPeople
{
    public Node? First { get; set; }

    public void AddToFront(Person Person)
    {
        if (First == null)
        {
            var node = new Node(Person);
            First = node;
        }
        else
        {
            var node = new Node(Person);
            node.Next = First;
            First = node;
        }
    }

    public void Clear()
    {
        First = null;
    }

}