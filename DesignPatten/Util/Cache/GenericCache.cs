// Administrator
// Joezhouman.DesignPatten
// Util
// 2021-04-21-11:35
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

using System;
using System.Collections.Generic;
using System.Threading;

namespace Joezhouman.DesignPattern.Util.Cache {
    public class GenericCache<TKey,TValue> {
        /// <summary>
        /// 缓存容器
        /// </summary>
        private Dictionary<TKey, TValue> _dictionary = new();
        /// <summary>
        /// 单写多读线程锁
        /// </summary>
        private ReaderWriterLock _rwLock = new();
        /// <summary>
        /// 超时时间
        /// </summary>
        private readonly TimeSpan _lockOutTime = TimeSpan.FromMilliseconds(100);
        /// <summary>
        /// 添加指定键值对
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException">指定的键已存在</exception>
        public void Add(TKey key, TValue value) {
            bool existing = false;
            _rwLock.AcquireWriterLock(_lockOutTime);
            try {
                if (_dictionary.ContainsKey(key)) {
                    existing = true;
                }
                else {
                    _dictionary.Add(key, value);
                }
            }
            finally{_rwLock.ReleaseWriterLock();}

            if (existing)
                throw new ArgumentException($"{nameof(key)} is existing" );
        }
        /// <summary>
        /// 获取指定键对应的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value">找到指定键，返回该键对应的值；否则，返回value类型的默认值</param>
        /// <returns>是否含有指定的键</returns>
        public bool TryGetValue(TKey key, out TValue value) {
            _rwLock.AcquireReaderLock(_lockOutTime);
            bool success;
            try {
                success = _dictionary.TryGetValue(key, out value);
            }
            finally{_rwLock.ReleaseReaderLock();}

            return success;
        }
        /// <summary>
        /// 移除所有的键值
        /// </summary>
        public void Clear() {
            if (_dictionary.Count == 0) {
                return;
            }
            _rwLock.AcquireWriterLock(_lockOutTime);
            try {
                _dictionary.Clear();
            }
            finally{_rwLock.ReleaseWriterLock();}
        }
        /// <summary>
        /// 是否包含指定的键
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(TKey key) {
            if (_dictionary.Count<=0) {
                return false;
            }

            bool contains;
            _rwLock.AcquireReaderLock(_lockOutTime);
            try {
                contains = _dictionary.ContainsKey(key);
            }
            finally{_rwLock.ReleaseReaderLock();}

            return contains;

        }
        //TODO Remove
        /// <summary>
        /// 键值对数目
        /// </summary>
        public int Count => _dictionary.Count;
    }
}