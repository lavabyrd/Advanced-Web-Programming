class Calculator:

    def __init__(self):
        self.__input = '0'
        self.__operation = ''


    def add(self, first, second):
        return first + second

    def multiply(self, first, second):
        return first * second

    def subtract(self, first, second):
        return first - second

    def division(self, first, second):
        return first / second

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


        # values to be shown after operator
        elif self.__operation != '':
            if self.__operation == '+':
                self.__input = str(self.add(int(self.__input), int(value)))
            elif self.__operation == '-':
                self.__input = str(self.subtract(int(self.__input), int(value)))
            elif self.__operation == '*':
                self.__input = str(self.multiply(int(self.__input), int(value)))
            elif self.__operation == '/':
                self.__input = str(self.division(int(self,__input), int(value)))
            else:
                return "invalid operator"

        else:
            self.__input += str(value)
        #print self.__input

    def getOutput(self):
        if self.__input == '0E':
            return 0
        return int(self.__input)