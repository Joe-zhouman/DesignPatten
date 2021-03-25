using System;

namespace Joezhouman.DesignPattern.CSharpFeature.Indexer {
    public class SingleColumnCollection {
        public SingleColumnCollection(string[] countries) {
            _countries = countries;
        }
        private static string[] _countries;
        public string this[int index] => _countries[index];
        public string[] this[string name] {
            get {
                if (_countries is null || _countries.Length <= 0) return null;
                return Array.FindAll(_countries, candidate => candidate.StartsWith(name));
            }
        }
    }
}