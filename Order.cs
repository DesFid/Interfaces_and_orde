using System;
using System.Collections.Generic;
public class Order{
    public List<string> Compare(List<string> _list){
        for (var y = 0; y < _list.Count; y++){
            var minor = _list[y];
            for (var x = y; x < _list.Count; x++){
            var comparision = _list[x].CompareTo(minor);
            if (comparision < 0)
                {
                minor = _list[x];
                var memory = _list[y];
                _list[y] = minor;
                _list[x] = memory;
                }
            };
        };
        return _list;
    }
}