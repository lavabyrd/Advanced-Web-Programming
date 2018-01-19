import math


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

    def exponent(self, first, second):
        return first ** second

    def squaretroot(self, first):
        return math.sqrt(first)

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
            self.__input = str(math.sqrt(float(self.__input)))

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

        return self.__input
        # else:
        #     try:
        #         int(self.__input)
        #     except ValueError:
        #         self.__input
