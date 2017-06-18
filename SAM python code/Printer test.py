

import win32ui
import random
import datetime
import time
mylist = []
today = datetime.date.today()
mylist.append(today)

hDC = win32ui.CreateDC ()
hDC.CreatePrinterDC ("PDFCreator")
hDC.StartDoc ("receipt")
hDC.StartPage ()
#constructing the page

#price = round(random.uniform(1.00,1.75),2)
userinput = float(input("The cents will be: "))
total = round(1+userinput/100,2)
price = round(total/1.06,2)
btw = round(total-price,2)
print( "the price is "+str(total))


file = open('receiptno.txt', 'r') 
receiptno = int(file.readline())
receiptno+=1
file = open('receiptno.txt', 'w')
file.write(str(receiptno))
file.close()

pagewidth =390

fontsize = 32
linedistance = int(1.2*fontsize)

fontnormal = win32ui.CreateFont({
    "name": "Roboto",
    "height": fontsize,
    "weight": 500,
})
fontitalic = win32ui.CreateFont({
    "name": "Roboto",
    "height": int(fontsize*0.6),
    "weight": 400,
    "italic": True,
})
fontbig = win32ui.CreateFont({
    "name": "Roboto",
    "height": int(fontsize*1.1),
    "weight": 700,
})

hDC.SelectObject(fontnormal)
hDC.TextOut(170,1*linedistance,"SAM")
hDC.TextOut(2,2*linedistance,"Symbiotic Autonomous Machine")

hDC.SelectObject(fontitalic)
hDC.TextOut(0,6*linedistance,"R n."+str(receiptno).zfill(3) )
hDC.TextOut(240,6*linedistance,time.strftime("%H:%M:%S")+"  "+str(mylist[0]))

hDC.SelectObject(fontnormal)
hDC.TextOut(0,8*linedistance,"1 cup kefir soda")
hDC.TextOut(320,8*linedistance,u"\u20ac"+"%0.2f" %price)
hDC.TextOut(0,9*linedistance,"BTW 6%")
hDC.TextOut(320,9*linedistance,u"\u20ac"+"%0.2f" %btw)
hDC.TextOut(0,11*linedistance,"Total")
hDC.TextOut(320,11*linedistance,u"\u20ac"+"%0.2f" %total)

hDC.TextOut(50,15*linedistance,"Rate your soda out of 5")
hDC.TextOut(25,16*linedistance,"on twitter @nonhumanSAM")

hDC.SelectObject(fontbig)
hDC.TextOut(10,18*linedistance,"Thanks for keeping me alive")
hDC.TextOut(80,19*linedistance,"and functioning!")

hDC.SelectObject(fontitalic)
hDC.TextOut(90,21*linedistance,"email: sam@nonhuman.club")
hDC.TextOut(110,int(21.5*linedistance),"web: nonhuman.club")

pen = win32ui.CreatePen(0, 1, 0)
hDC.SelectObject(pen)
hDC.MoveTo(pagewidth,0)#margin line, remove later
hDC.LineTo(pagewidth,1000)#margin line, remove later

hDC.MoveTo(0,int(3.5*linedistance))
hDC.LineTo(pagewidth,int(3.5*linedistance))

hDC.MoveTo(0,int(14.5*linedistance))
hDC.LineTo(pagewidth,int(14.5*linedistance))

hDC.MoveTo(0,int(20.5*linedistance))
hDC.LineTo(pagewidth,int(20.5*linedistance))


hDC.EndPage ()
hDC.EndDoc ()
