﻿using System;
namespace Mapservice_Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : Attribute
    {
        public bool Value { get; set; }

        public RequiredAttribute() : this(true)
        {
        }

        public RequiredAttribute(bool value) 
        {
            this.Value = value;
        }
    }
}
