linedistance = 40


import win32ui
import random
import datetime
import time
mylist = []
today = datetime.date.today()
mylist.append(today)

hDC = win32ui.CreateDC ()
hDC.CreatePrinterDC ("POS-58")
hDC.StartDoc ("the JOB of jobs")
hDC.StartPage ()
#constructing the page

font = win32ui.CreateFont({
    "name": "Courier New",
    "height": 30,
    "weight": 700,
})
hDC.SelectObject(font)

hDC.TextOut(0,0*linedistance,"########################")
hDC.TextOut(0,1*linedistance,"Tnx for drinkin ma juice")
hDC.TextOut(0,2*linedistance,"it was €1."+str(random.randint(0,9))+str(random.randint(0,9)))
hDC.TextOut(0,3*linedistance,"sam@nonhuman.club")
hDC.TextOut(0,4*linedistance,time.strftime("%H:%M:%S")+"  "+str(mylist[0]))
hDC.TextOut(0,5*linedistance,"%%%%%%%%%%%%%%%%%%%%%%%%")

pen = win32ui.CreatePen(0, 10, 0)
hDC.SelectObject(pen)
hDC.MoveTo(0,0)
hDC.LineTo(100,100)

hDC.EndPage ()
hDC.EndDoc ()
