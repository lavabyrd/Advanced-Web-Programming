from calculator import Calculator

my_calc = Calculator()
value = ''
while value != 'E':
   value = raw_input('Press Number or E to Finish: ')
   my_calc.input(value)
   print my_calc.getOutput()