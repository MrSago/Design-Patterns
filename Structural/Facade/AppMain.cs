using System;
using Facade;

// FacadeClass facade = new();
// Console.Write(facade.OperationResult());

var e = new Example<int>(5);
e.DisplayValue();

var a = new Example<string>("Hello, World!");
a.DisplayValue();