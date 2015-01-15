namespace System.Collections.Specialized
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a collection of associated String keys and String values that can be accessed either with the key 
    /// or with the index.
    /// </summary>
    public class NameValueCollection : IEnumerable<KeyValuePair<string, string>>
    {
        // Fields
        private readonly List<KeyValuePair<string, string>> items;

        /// <summary>
        /// Gets the entry at the specified index of the NameValueCollection.
        /// </summary>
        /// <param name="index">The zero-based index of the entry to locate in the collection.</param>
        /// <returns>A <see cref="T:System.String" /> that contains the comma-separated list of values at the specified index of the collection.</returns>
        public string this[int index]
        {
            get { return Get(items[index].Key); }
        }

        /// <summary>
        /// Gets or sets the entry with the specified key in the NameValueCollection.
        /// </summary>
        /// <param name="name">The String key of the entry to locate. The key can be null.</param>
        /// <returns>A <see cref="T:System.String" /> that contains the comma-separated list of values associated with the specified key, if found; otherwise, null.</returns>
        public string this[string name]
        {
            get { return Get(name); }
        }

        /// <summary>
        /// Gets all the keys in the NameValueCollection.
        /// </summary>
        /// <remarks>If the collection is empty, this method returns an empty String array, not null.</remarks>
        public IEnumerable<string> AllKeys
        {
            get { return items.Select(kvp => kvp.Key).Distinct(); } // <-- No duplicates returned.
        }

        /// <summary>
        /// Get or set whether all the values associated with the specified key from the NameValueCollection should be grouped using the comma separator. Default is false.
        /// </summary>
        public bool GroupByCommaSeparatedValues
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameValueCollection"/> class that is empty, has the default initial 
        /// capacity and uses the default case-insensitive hash code provider and the default case-insensitive comparer.
        /// </summary>
        public NameValueCollection()
        {
            items = new List<KeyValuePair<string, string>>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameValueCollection"/> class that is empty, has the specified initial 
        /// capacity and uses the default case-insensitive hash code provider and the default case-insensitive comparer.
        /// </summary>
        /// <param name="capacity"></param>
        public NameValueCollection(int capacity)
        {
            items = new List<KeyValuePair<string, string>>(capacity);
        }

        /// <summary>
        /// Copies the entries in the specified <see cref="T:System.Collections.Specialized.NameValueCollection" /> to the current <see cref="T:System.Collections.Specialized.NameValueCollection" />.
        /// </summary>
        /// <param name="pairs">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to copy to the current <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
        public void Add(IEnumerable<KeyValuePair<string, string>> pairs)
        {
            if (pairs == null)
                throw new ArgumentNullException("pairs");

            foreach (var kvp in pairs)
            {
                Add(kvp.Key, kvp.Value);
            }
        }

        /// <summary>
        /// Adds an entry with the specified name and value to the <see cref="NameValueCollection"/>.
        /// </summary>
        /// <param name="name">The String key of the entry to add. The key can be null.</param>
        /// <param name="value">The Object value of the entry to add. The value can be null.</param>
        public void Add(string name, object value)
        {
            name = name ?? String.Empty;
            value = value ?? String.Empty;

            items.Add(new KeyValuePair<string, string>(name, value.ToString()));
        }

        /// <summary>
        /// Gets the values associated with the specified name combined into one comma-separated list.
        /// </summary>
        /// <param name="name">The name of the entry that contains the values to get. The name can be null.</param>
        /// <returns>A <see cref="T:System.String" /> that contains a comma-separated list of url encoded values associated with the specified name if found; otherwise, null. The values are Url encoded.</returns>
        public string Get(string name)
        {
            return String.Join(",", GetValuesInternal(name));
        }

        /// <summary>
        /// Gets the values associated with the specified key from the NameValueCollection.
        /// </summary>
        /// <param name="name">The name of the entry that contains the values to get. The name can be null.</param>
        /// <returns>A <see cref="T:System.String" /> that contains url encoded values associated with the name, or null if the name does not exist.</returns>
        public string[] GetValues(string name)
        {
            return GetValuesInternal(name).ToArray();
        }

        private IEnumerable<string> GetValuesInternal(string name)
        {
            return items.Where(kvp => String.Compare(kvp.Key, name, StringComparison.OrdinalIgnoreCase) == 0).Select(kvp => kvp.Value).ToList();
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        /// <summary>
        /// Converts the content of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>The string representation of the value of this instance, multiple values with a single key are comma separated.</returns>
        public override string ToString()
        {
            return String.Concat("?", GroupByCommaSeparatedValues
                ? String.Join("&", AllKeys.Select(key => new { key, value = GetValues(key).Aggregate((s, next) => String.Concat(s, ",", next)) }).Select(pair => String.Join("=", pair.key, Uri.EscapeDataString(pair.value))))
                : String.Join("&", AllKeys.SelectMany(GetValues, (key, value) => String.Join("=", key, Uri.EscapeDataString(value)))));
        }
    }
}