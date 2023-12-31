﻿namespace SharpTutorial
{
    internal interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetFullName();
        string GetDescription();
        string[] GetDescriptionArray();
    }
}
