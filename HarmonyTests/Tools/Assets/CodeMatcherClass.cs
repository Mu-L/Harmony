namespace HarmonyTests.Tools.Assets
{
	public class CodeMatcherClass
	{
		public static void Method()
		{
			Foo();
			Bar("hello");
		}

		public static void Foo()
		{
		}

		public static void Bar(string s)
		{
		}
	}
}
