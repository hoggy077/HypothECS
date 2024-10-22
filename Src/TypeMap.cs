

namespace HypothECS
{
    internal static class TypeMap
    {
        /* Notes:
         *  - Consider any additional info to be included & replace int with a metadata struct
         */

        static Dictionary<Type, int> _types = new();

        public static int GetType<T>() => GetType(typeof(T));
        public static int GetType(Type type)
        {
            if(_types.TryGetValue(type, out var Index))
                return Index;
            _types.Add(type, _types.Count);
            return _types.Count-1;
        }

    }
}
