### THIS MAY NOT PROPERLY WORK HERE, PLEASE TRY ANOTHER COMPILER ###
print("DAVAY FELLAS!\n\n")

print("Hi there!")

### THE LISTS FOR THE PLACES AND ALL DAYS ###
all_places = ["Bakırköy", "Florya", "Kadıköy/Bostancı", "Taksim", "Karaköy", "Tekirdağ/Ereğli"]
all_days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"]
yes = ("YES, Yes, yes, Y, y, YEAP, yeap, YEAH, yeah")
no = ("NO, No, no, N, y, NOPE, nope, NAH, nah")

### MEETING DAY CHECK ###
def meetday_Func():
  d1 = input("\nWhen would you like to meet up? Please specify the day: ")
  if d1 not in all_days:
    print("Please enter a day!")
    meetday_Func()
  else:
    print("\nPossible options:")
    print(*all_places, sep="\n")
    meetplace_Func()

### MEETING PLACE CHECK ###
def meetplace_Func():
  place1 = input("\nWhere would you like to go?\n")
  if place1 in all_places:
    print("Great!\n")
    meettime_Func()
  else:
    print("Not listed above, but okay.\n")
    all_places.append(place1)
    meettime_Func()

def meettime_Func():
  time1 = input("What time are you available?\nPlease specify the hour as hh.mm: ")
  if "." in time1:
    print("Okay, we got all we need!")
    import time
    time.sleep(1)
    print("\nBut, wait a minute..\n")
    time.sleep(3)
    print("One last thing!")
    carask_Func()
  else:
    print("Please enter a valid info!\n")
    meettime_Func()

### CAR CHECK ###
def carask_Func():
  car_check = input("How will you get there? You got car?\n")
  if car_check in yes:
    print("\nGreat! It will be useful.")
  elif car_check in no:
    print("\nSorry.. But it's fine!")
  else:
    print("Please enter a valid answer!\nLet's start over!\n")
    carask_Func()

### INSISTING ###
def retry_Func():
  print("But..")
  import time
  time.sleep(3)
  retry = input("Are you sure? ")
  if retry in yes:
    print("OK, SEE YOU LATER! :(")
  elif retry in no:
    meetday_Func()
  else:
    print("Not a valid answer. Let's start over!")
    retry_Func()

### THE PROJECT "DAVAY" BEGINGS ###
def check1_Func():
  n1 = input("Please enter your name and surname: ")
  if n1.isdigit():
    print("Please enter valid info!\n")
    check1_Func()
  else:
    print("Hello, ", n1)
    hang = input("\nWould you like to hangout?\n")
    if hang in yes:
      meetday_Func()
    elif hang in no:
      print("We are sorry!")
      retry_Func()  
    else:
      print("Please enter a valid answer!")
      check1_Func()
          
class Fella:
  def __init__(self, name, day, place):
    self.name = n1
    self.day = d1
    self.place = place1

check1_Func()
