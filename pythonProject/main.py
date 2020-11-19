from os import system, name
from time import *
import datetime

#
# This program allows you to ask the program different questions and get answered
#

# While True it does all kinds of questions using if and elif statements
while True:

    Choise = input('Naomi: Hi User\nWhat would you like to know?:\n')

    if Choise == 'joke' or Choise == 'Joke' or Choise == 'joke.' or Choise == 'Joke.' or Choise == 'i would like to know a joke':
        print('\nNaomi: Knock, knock\nWho is there?\nLeon:\nLeon who?\nLeon me when you are not strong!\n')
    elif Choise == 'quit' or Choise == 'q':
        print('Naomi: Good bye User')
        break
    elif Choise == 'date' or Choise == 'current date':
        now = datetime.datetime.now()
        print('Naomi: Your Current date and time is: ')
        print(now.strftime('%Y-%m-%d %H:%M:%S\n'))
    elif Choise == 'name' or Choise == 'what is your name?' or Choise == 'your name':
        print('My name is Naomi\n')
    else:
        print('\nInvalid input\n')
        sleep(0.5)
        print("""
        Naomi: Here's all of my working commands:
        "joke" or "Joke" or "joke." or "Joke." or "i would like to know a joke" prints a joke.
        "quit" or "q" quits the app.
        "date" or "current date" shows current date.
        "name" or "what is your name?" or "your name" tells User the program name
                  
        """)
# ENDIF
# EOF
