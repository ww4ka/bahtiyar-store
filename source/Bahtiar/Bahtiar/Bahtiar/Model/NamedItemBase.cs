﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bahtiar.Model
{
    public abstract class NamedItemBase : EntityBase
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id == value)
                    return;
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                    return;
                _name = value;
                OnPropertyChanged();
            }
        }
    }
}