#include "pch.h"
#include "CppUnitTest.h"
#include "..\\6\Functions.h"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{ 
	public:
		
		TEST_METHOD(TestMethod1)
		{
			a = 5;
			b = 10;
			n = 1000;
			Assert::AreEqual(0.358, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod2)
		{
			a = 10;
			b = 50;
			n = 1000;
			Assert::AreEqual(0.53, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod3)
		{
			a = 4;
			b = 100;
			n = 1500;
			Assert::AreEqual(1.201, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod4)
		{
			a = 8;
			b = 130;
			n = 1070;
			Assert::AreEqual(0.851, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod5)
		{
			a = 54;
			b = 104;
			n = 899;
			Assert::AreEqual(0.152, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod6)
		{
			a = 2;
			b = 6;
			n = 160;
			Assert::AreEqual(0.95, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod7)
		{
			a = 7;
			b = 18;
			n = 765;
			Assert::AreEqual(0.396, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod8)
		{
			a = 23;
			b = 56;
			n = 999;
			Assert::AreEqual(0.25, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod9)
		{
			a = 52;
			b = 700;
			n = 1800;
			Assert::AreEqual(0.506, round(reshenie(a, b, n) * 1000) / 1000);
		}
		TEST_METHOD(TestMethod10)
		{
			a = 5;
			b = 15;
			n = 674;
			Assert::AreEqual(0.52, round(reshenie(a, b, n) * 1000) / 1000);
		}
	};
}
