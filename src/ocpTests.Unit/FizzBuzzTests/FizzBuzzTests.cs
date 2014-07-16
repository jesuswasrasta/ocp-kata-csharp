using System.Collections.Generic;
using NUnit.Framework;
using Ocp.FizzBuzz;

namespace ocpTests.Unit.FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
         private FizzBuzzGame _game;
        
		[SetUp]
		public void SetUp()
		{
		    var regole = new List<IRegola> {new RegolaMultiplaDi1(), new RegolaMultiploDi3(), new RegolaMultiploDi5(), new RegolaMultiplaDi7()};
            _game = new FizzBuzzGame(regole);
		}

		[Test]
		public void JustSayTheNumber() 
	    {
			Assert.AreEqual("1", _game.Say(1));
			Assert.AreEqual("2", _game.Say(2));
		}

		[Test]
		public void MultiplesOfThree()
	    {
			Assert.AreEqual("Fizz", _game.Say(3));
			Assert.AreEqual("Fizz", _game.Say(6));
		}

		[Test]
		public void MultiplesOfFive()
	    {
			Assert.AreEqual("Buzz", _game.Say(5));
			Assert.AreEqual("Buzz", _game.Say(10));
		}

		[Test]
		public void MultiplesOfFiveAndThree() 
	    {
			Assert.AreEqual("FizzBuzz", _game.Say(15));
			Assert.AreEqual("FizzBuzz", _game.Say(30));
		}

		[Test
        ]
		public void MultiplesOfSeven() 
	    {
			Assert.AreEqual("Bang", _game.Say(7));
			Assert.AreEqual("Bang", _game.Say(14));
		}

		[Test]
		public void MultiplesOfSevenAndThree() 
		{
			Assert.AreEqual("FizzBang", _game.Say(7*3));
			Assert.AreEqual("FizzBang", _game.Say(7*3*2));
		}

		[Test, Ignore]
		public void CountNumberOfCalls() 
		{
			_game.Say (1);
			_game.Say (1);
			_game.Say (1);
			//			Assert.AreEqual(3, _stats.Get["calls-count"]);
		}

		[Test, Ignore]
		public void CountSum() 
		{
			_game.Say (1);
			_game.Say (7);
			_game.Say (13);
			//			Assert.AreEqual(21, _stats.Get["calls-sum"]);
		}
	}
}