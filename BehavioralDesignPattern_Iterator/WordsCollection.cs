using System.Collections;

namespace BehavioralDesignPattern_Iterator
{
    // Concrete Collections provide one or several methods for retrieving fresh
    // iterator instances, compatible with the collection class.
    public class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReverseDirection()
            => _direction = !_direction;

        public List<string> getItems() 
            => _collection;

        public void AddItem(string item)
            => this._collection.Add(item);

        public override IEnumerator GetEnumerator()
            => new AlphabeticalOrderIterator(this, _direction);
    }
}
