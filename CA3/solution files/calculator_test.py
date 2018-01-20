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
        self.assertEqual('Invalid choice', calculator.getOutput())
        
    def testAddInput(self):
        calculator = Calculator()
        calculator.input(1)
        calculator.input(2)
        calculator.input(5)
        calculator.input(9)
        self.assertEqual('1259', calculator.getOutput())
        calculator.input('#')
        self.assertEqual('0', calculator.getOutput())

    def testAddZeroes(self):
        calculator = Calculator()
        calculator.input(0)
        calculator.input(0)
        calculator.input(0)
        self.assertEqual('0', calculator.getOutput())

    def testAddition(self):
        calculator = Calculator()
        calculator.input(5)
        calculator.input('+')
        calculator.input('7')
        self.assertEqual('12', calculator.getOutput())

    def testSquare(self):
        calculator = Calculator()
        calculator.input(4)
        calculator.input('squared')
        self.assertEquals('16', calculator.getOutput())

    def testCube(self):
        calculator = Calculator()
        calculator.input(3)
        calculator.input('cubed')
        self.assertEquals('27', calculator.getOutput())

    def testSquareroot(self):
        calculator = Calculator()
        calculator.input(9)
        calculator.input('sqr')
        self.assertEquals('3', calculator.getOutput())

    def testCuberoot(self):
        calculator = Calculator()
        calculator.input(8)
        calculator.input('cbr')
        self.assertEquals('2', calculator.getOutput())

    def testExponent(self):
        calculator = Calculator()
        calculator.input(2)
        calculator.input('**')
        calculator.input(6)
        self.assertEquals('64', calculator.getOutput())

    def testLog(self):
        calculator = Calculator()
        calculator.input(4)
        calculator.input('nlog')
        self.assertEquals('1.38629436112', calculator.getOutput())

    def testExit(self):
        calculator = Calculator()
        calculator.input('E')
        self.assertEqual('exiting', calculator.getOutput())




unittest.main()
