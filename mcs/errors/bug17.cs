// we do not flag the lack of member ToBoolean in double
//
class X {
	static void Main ()
	{
double x = 64.0;
System.Console.WriteLine("x = " + x.ToBoolean(null));
}
}
