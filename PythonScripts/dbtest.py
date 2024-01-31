import pyodbc
from dbtestconfig import *
from helpers import *
import random

conn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER=group-6.database.windows.net;DATABASE=ClassRegistry;UID=group6;PWD=Test123456;')
cur = conn.cursor()

#count = 1

#sqlCommit(f"INSERT INTO Students VALUES (1, 'Jam', 'Bsata', 1)")

#count += 1

fNameslist = []
lNameslist = []
classesList = []

fileFnames = open("firstnames.txt", "r")

count1 = 0
for i in fileFnames:
    if count1 >= 1000:
        pass
    elif count1 < 1000:
        fNameslist.append(i.strip())
        count1 += 1
        
fileFnames.close()

fileLnames = open("lastnames.txt", "r")

count2 = 0
for i in fileLnames:
        if count2 >= 1000:
            pass
        elif count2 < 1000:
            lNameslist.append(i.strip())
            count2 += 1

fileLnames.close()

fileClassNames = open("schoolClasses.txt", "r")

for i in fileClassNames:
    classesList.append(i.strip())
    
fileClassNames.close()

def randomActivityBit():
    roll = houseRoll()
    if roll <=5:
        return 0
    else:
        return 1

def randomClass():
    roll = houseRoll()
    while roll >38:
        roll = houseRoll()
    if roll <=38:
        return roll

print(len(classesList))

activityBitList = []

for i in range(1000):
    act = randomActivityBit()
    activityBitList.append(act)

studentIdList = []

for i in range(1000):
    studentIdList.append(i)

studentIdList.pop(0)

#for i in range(2, 999, 1):
#    sqlCommit(f"INSERT INTO Students VALUES ({str(studentIdList[i])}, '{fNameslist[i]}', '{lNameslist[i]}', {str(activityBitList[i])})")

for i in range(100):
    sqlCommit(f"INSERT INTO Courses VALUES ({str(studentIdList[i])}, '{classesList[randomClass()]}')")
