﻿namespace Deploy.Data
{
    internal class Column
    {
        public Column(string name, DataType type, Constraint constraint, bool primaryKey, int length = 255)
        {
            Name = name;
            Type = type;
            Constraint = constraint;
            PrimaryKey = primaryKey;
        }

        public string Name { get; }

        public DataType Type { get; }

        public bool PrimaryKey { get; }

        public Constraint Constraint { get; }

        public int Length { get; }
    }
}
