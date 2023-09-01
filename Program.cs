// See https://aka.ms/new-console-template for more information
using DigitalSytemWithCSharp.Entities;
var number = new ConvertNumericalBase(255.55);
number.ConvertDecimalToOther(2);

var n = new NumberBaseConverter(255.55);
Console.WriteLine(n.getNumberBaseConvert(2));


