import math
from math import sqrt, log


class Calculator:

    def __init__(self):
        self.__input = ''
        self.__operation = ''

    def add(self, first, second):
        return first + second

    def multiply(self, first, second):
        return first * second

    def subtract(self, first, second):
        return first - second

    def division(self, first, second):
        return first / second

    # this takes the first value and uses the second value for the power of value
    def exponent(self, first, second):
        return first ** second

    # returns the square root of the value entered before it
    def squaretroot(self, first):
        return sqrt(first)

    # returns the cubed root of the value entered before it
    def cubedroot(self, first):
        return first ** (1.0/3.0)

    def square(self, first):
        return first * first

    def cube(self, first):
        return first * first * first

    def nlog(self,first):
        return log(first)

    # working functionality of app begins here
    def input(self, value):
        if value == '#':
            self.__input = '0'

        # valid operators
        elif value == '+':
            self.__operation = value
        elif value == '-':
            self.__operation = value
        elif value == '*':
            self.__operation = value
        elif value == '/':
            self.__operation = value
        elif value == '**':  # this is the power operator - exponent
            self.__operation = value
        elif value == 'sqr':
            # print self.__input
            # self.__input = float(self.__input)
            self.__input = str(self.squaretroot(float(self.__input)))
        elif value == 'cbr':
            self.__input = str(self.cubedroot(float(self.__input)))
        elif value == 'squared':
            self.__input = str(self.square(float(self.__input)))
        elif value == 'cubed':
            self.__input = str(self.cube(float(self.__input)))
        elif value == 'nlog':
            self.__input = str(self.nlog(float(self.__input)))

        # values to be shown after operator
        elif self.__operation != '':
            if self.__operation == '+':
                self.__input = str(self.add(float(self.__input), float(value)))
            elif self.__operation == '-':
                self.__input = str(self.subtract(float(self.__input), float(value)))
            elif self.__operation == '*':
                self.__input = str(self.multiply(float(self.__input), float(value)))
            elif self.__operation == '/':
                self.__input = str(self.division(float(self.__input), float(value)))
            elif self.__operation == '**':
                self.__input = str(self.exponent(float(self.__input), float(value)))
            else:
                return "invalid operator"

        else:
            self.__input += str(value)
        # print self.__input

    def getOutput(self):
        if self.__input == '0E':
            return 0

        # handles conversion of self.__input back to not having a trailing 0 if its a whole number
        try:
            if float(self.__input).is_integer() == True:
                self.__input = str(int(float(self.__input)))
                return self.__input
        except:
            return self.__input
