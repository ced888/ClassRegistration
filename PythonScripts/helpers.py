from typing import Final
from telegram import Update
from telegram.ext import Application, CommandHandler, MessageHandler, filters, ContextTypes
from operator import itemgetter
import random
from configERCTB import *
from datetime import datetime
import pyodbc
from dbtestconfig import  *
import time


#MicrosoftQL connection

conn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER=group-6.database.windows.net;DATABASE=ClassRegistry;UID=group6;PWD=Test123456;')

cur = conn.cursor()

def houseRoll():
    roll=random.randint(1,100)
    return roll

def formatNum(num):
    return ("{:,}".format(num))

def tradesPrint(tradeList):
    targString = '\n'
    for i in range(len(tradeList)):
        targString += ('Trade #: ' + str(tradeList[i][0]) + ' Destination Client ID: ' + (str(tradeList[i][1])) + ' Time : ' + str(formatNum(tradeList[i][2])) + '\n')
    return targString

def currentTime():
    now = datetime.now()
    timestamp = datetime.timestamp(now)
    return timestamp

def sqlCommit(string):
    cur.execute(string)
    conn.commit()

def sqlSelect(string):
    cur.execute(string)
    targString = cur.fetchone()
    conn.commit()
    return targString

def sqlMultiSelect(string):
    cur.execute(string)
    targString = cur.fetchall()
    conn.commit()
    return targString

def sqlToList(listofTuples):
    newList = []
    for i in range(len(listofTuples)):
        newList.append(listofTuples[i][0])
    return newList
