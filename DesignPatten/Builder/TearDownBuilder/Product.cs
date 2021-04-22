// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-22-15:00
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

namespace Joezhouman.DesignPattern.Builder.TearDownBuilder {
    public class Product {
        public int count;
        public IList<int> item;
    }

    public class ProductBuilder : IBuilder<Product> {
        private Product _product = new ();
        private readonly Random _random = new();

        public Product BuildUp() {
            _product.count = 0;
            _product.item = new List<int>();
            for (int i = 0; i < 5; i++) {
                _product.item.Add(_random.Next());
                _product.count++;
            }

            return _product;
        }

        public Product TearDown() {
            while (_product.count>0) {
                _product.item.RemoveAt(_product.count);
                _product.count--;
            }

            return _product;
        }

    }
}