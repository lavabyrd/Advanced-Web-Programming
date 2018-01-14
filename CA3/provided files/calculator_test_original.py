import unittest
from calculator import Calculator

class CalculatorTest(unittest.TestCase):
    def testAdd(self):
        calculator = Calculator()
        self.assertEqual(4, calculator.add(2, 2))
        self.assertEqual(5, calculator.add(2, 3))
        self.assertEqual(-1, calculator.add(2, -3))
        self.assertEqual(0, calculator.add(2, -2))
        self.assertEqual(2, calculator.add(2, 0))
        self.assertEqual(-5, calculator.add(-2, -3))

    def testSubtract(self):
        # arrange
        calculator = Calculator()
        self.assertEqual(0, calculator.subtract(2, 2))
        self.assertEqual(-1, calculator.subtract(2, 3))
        self.assertEqual(5, calculator.subtract(2, -3))
        self.assertEqual(4, calculator.subtract(2, -2))
        self.assertEqual(2, calculator.subtract(2, 0))
        self.assertEqual(1, calculator.subtract(-2, -3))

    def testMultiply(self):
        calculator = Calculator()
        self.assertEqual(4, calculator.multiply(2, 2))
        self.assertEqual(6, calculator.multiply(2, 3))
        self.assertEqual(-6, calculator.multiply(2, -3))
        self.assertEqual(-4, calculator.multiply(2, -2))
        self.assertEqual(0, calculator.multiply(2, 0))
        self.assertEqual(6, calculator.multiply(-2, -3))
        self.assertEqual(2, calculator.multiply(2, 1))
        self.assertEqual(3, calculator.multiply(2, 1.5))

    def testInitialOutput(self):
        calculator = Calculator()
        self.assertEqual(0, calculator.getOutput())
        
    def testAddInput(self):
        calculator = Calculator()
        calculator.input(1)
        calculator.input(2)
        calculator.input(5)
        calculator.input(9)
        self.assertEqual(1259, calculator.getOutput())
        calculator.input('#')
        self.assertEqual(0, calculator.getOutput())

    def testAddZeroes(self):
        calculator = Calculator()
        calculator.input(0)
        calculator.input(0)
        calculator.input(0)
        self.assertEqual(0, calculator.getOutput())

    def testAddition(self):
        calculator = Calculator()
        calculator.input(5)
        calculator.input('+')
        calculator.input('7')
        self.assertEqual(12, calculator.getOutput())

    def testExit(self):
        calculator = Calculator()
        calculator.input('E')
        self.assertEqual(0, calculator.getOutput())

unittest.main()
