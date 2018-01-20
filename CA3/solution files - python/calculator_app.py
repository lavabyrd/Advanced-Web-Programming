from calculator import Calculator

print("welcome to our calculator app!")
print("")
print("We have the following options available, Addition, Subtraction, multiplication and division using '+','-','*' and '/'.")
print("Also exponential '**', natural log, 'nlog', square 'squared', cubed 'cubed', squareroot 'squareroot' and cubedroot 'cubedroot'.")
print("")


my_calc = Calculator()
value = ''
while value != 'E':
   value = raw_input('Enter a Number or E to Finish: ')
   my_calc.input(value)
   print my_calc.getOutput()