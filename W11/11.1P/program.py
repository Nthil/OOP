
from time import sleep
from clock import Clock

clock = Clock()

for x in range(86400):
    clock.Tick()
    print(clock.Time)
    sleep(1)