﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization
{
    class Person
    {
        [XmlAttribute(AttributeName = "code")]
        public int Id { get; set; }
        [XmlElement(ElementName = "FullName")]
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
