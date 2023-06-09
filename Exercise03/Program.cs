Console.WriteLine("Input number of strings to store in ethe array :");

var numberOfArray =	Console.ReadLine();

string[] Element = new string[Convert.ToInt32(numberOfArray)];

Console.WriteLine($"Input {numberOfArray} strings for the array :");

for (int i = 0; i < Element.Length; i++)
{
	Console.WriteLine($"Element[{i}] :");
	Element[i] = Console.ReadLine();
}
Console.WriteLine("Input the minimum length of the item you want to find :");

var minimumLength = Convert.ToInt32(Console.ReadLine());

foreach (var item in Element)
{
	if (item.Length >= minimumLength)
	{
		Console.WriteLine($"Item : {item}");
	}

}
Console.ReadKey();
//=======================================================================
//Example
//Exercise : Find the strings for a specific minimum length :
//------------------------------------------------------
//Input number of strings to  store in the array :5

//Input 5 strings for the array  :
//Element[0] : my
//Element[1] : name
//Element[2] : is
//Element[3] : Armam
//Element[4] : Abi

//Input the minimum length of the item you want to find : 3

//The items of minimum 3 characters are :
//Item: Abi
//Item: Armam
//Item: name
//Exercise : Find the strings for a specific minimum length :
//------------------------------------------------------
//Input number of strings to  store in the array :5

//Input 5 strings for the array  :
//Element[0] : my
//Element[1] : name
//Element[2] : is
//Element[3] : Armam
//Element[4] : Abi

//Input the minimum length of the item you want to find : 3

//The items of minimum 3 characters are :
//Item: Abi
//Item: Armam
//Item: name
