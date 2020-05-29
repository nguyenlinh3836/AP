﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class Product
    {
        protected int id;
        protected string name;
        protected double price;
        protected string producer;
        public Product(int id, string name, double price, string producer){
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }      
        public abstract double computeTax();
    }
}
