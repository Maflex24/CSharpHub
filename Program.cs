using System.Threading.Channels;
using CSharpHub;
using CSharpHub.SomeInterview;

Console.WriteLine(RemoveTheParenthies.RemoveParentheses("example(unwanted thing)example"));
var spaces = RemoveTheParenthies.RemoveParentheses(" ");
Console.WriteLine(spaces.Length);

// -------------------
Console.WriteLine();
Console.WriteLine(PinValidator.ValidatePin("12345"));
Console.WriteLine(PinValidator.ValidatePin("01234564848"));
Console.WriteLine(PinValidator.ValidatePin("123456"));
Console.WriteLine(PinValidator.ValidatePin("1234"));
// ..................

Console.WriteLine();
Console.WriteLine(WhoLikes.Likes(new string[] { }));
Console.WriteLine(WhoLikes.Likes(new string[] { "Lars" }));
Console.WriteLine(WhoLikes.Likes(new string[] { "Lars", "Marco" }));
Console.WriteLine(WhoLikes.Likes(new string[] { "Lars", "Marco", "Giovani" }));
Console.WriteLine(WhoLikes.Likes(new string[] { "Lars", "Marco", "Giovani", "Theresa" }));


Console.WriteLine();
Console.WriteLine("For input: 9948491, result: " + SeparateOddNumbers.Separate("9948491"));
Console.WriteLine("For input: 131312884411, result: " + SeparateOddNumbers.Separate("131312884411"));