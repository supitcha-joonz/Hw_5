// See https://aka.ms/new-console-template for more information
using HW_5;

Console.WriteLine("******* HW_5 : Interface *******\n");

Console.WriteLine("----- Doctor -----\n");
var doctor = new Doctor("Joonz", "Doctor", 50000m, 7);
var docWhoamI = doctor.WhoAmI();
var docTax = doctor.GetTax();
Console.WriteLine($"Who Am I : {docWhoamI}.\n");
Console.WriteLine($"Get Tax :  {docTax} Bath.\n");

Console.WriteLine("----- Police -----\n");
var police = new Police("Oil", "Police", 24500m, 3);
var poWhoamI = police.WhoAmI();
var poTax = police.GetTax();
Console.WriteLine($"Who Am I : {poWhoamI}.\n");
Console.WriteLine($"Get Tax :  {poTax} Bath.\n");

Console.WriteLine("----- Teacher -----\n");
var teacher = new Doctor("Tammy", "Teacher", 36520m, 5);
var teWhoamI = teacher.WhoAmI();
var teTax = teacher.GetTax();
Console.WriteLine($"Who Am I : {teWhoamI}.\n");
Console.WriteLine($"Get Tax :  {teTax} Bath.\n");

Console.WriteLine("************************************\n");